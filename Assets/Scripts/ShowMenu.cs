using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowMenu : MonoBehaviour
{
    public GameObject panel;

    public static bool gamePaused = false;
    
    void Start()
    {
        panel.SetActive(false);
        Resume();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Debug.Log("Pause");
        panel.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void Resume()
    {
        Debug.Log("Resume");
        panel.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void BackToMainMenu()
    {
        Debug.Log("BackToMenu");
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
