using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SceneSwitch()
    {
        SceneManager.LoadScene(1); //[int sceneBuildIndex] Tell the scenemanager which scene to load based on a index or variable
    }
}
