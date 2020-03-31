using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnoSceneSwitcher : MonoBehaviour
{
   public void SceneSwitch()
    {
        SceneManager.LoadScene(3); 
    }
}
