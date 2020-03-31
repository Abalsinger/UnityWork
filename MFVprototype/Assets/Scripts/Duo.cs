using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duo : MonoBehaviour
{
    public void SceneSwitch()
    {
        SceneManager.LoadScene(1);
    }
}

public class Three : MonoBehaviour
{
    public void SceneSwitch()
    {
        SceneManager.LoadScene(2);
    }
}
