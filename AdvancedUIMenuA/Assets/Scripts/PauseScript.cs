using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "UnMute";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
    }

    public void Resume ()
    {
        paused = false;
    }

    public void ManuMenu()
    {
        Application.LoadLevel(0);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("currentscenesave", Application.loadedLevel);
    }

    public void Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void Mute()
    {
        muted = !muted;
    }

    public void Quit()
    {
        Application.Quit();
            
    }

}
