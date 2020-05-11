using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{
    // What objects will be clickable
    public LayerMask clickAbleLayer;

    //Swap cursor per object
    public Texture2D pointer; //normal
    public Texture2D target; //clickable objects like the world
    public Texture2D doorway; //for doorways
    public Texture2D combat; //combat actions

    public EventVector3 onClickEnviroment;



    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickAbleLayer.value))
            {
            bool door = false;
            bool item = false;

            if(hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                door = true;
                    }
            else if(hit.collider.gameObject.tag == "Item")
            {
                Cursor.SetCursor(combat, new Vector2(16, 16), CursorMode.Auto);
                item = true;
            }
            else
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }
            if(Input.GetMouseButtonDown(0))
            {
                if(door)
                {
                    Transform doorway = hit.collider.gameObject.transform;
                    onClickEnviroment.Invoke(doorway.position);
                   Debug.Log("DOOR");
                }
                else if(item)
                {
                    Transform itemPos = hit.collider.gameObject.transform;
                    onClickEnviroment.Invoke(itemPos.position);
                }
                else
                {
                    onClickEnviroment.Invoke(hit.point);
                }                
            }
        }
        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }
