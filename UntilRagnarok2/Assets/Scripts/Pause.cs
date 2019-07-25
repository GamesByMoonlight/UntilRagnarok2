using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseCanvas;
    public Button ResumeButton;

    void Start()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        PauseAction();
    }

    public void PauseAction()
    {
        Debug.Log("PauseAction");

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyUp(KeyCode.P))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        Debug.Log("Toggle");
        pauseCanvas.SetActive(!pauseCanvas.activeSelf);

        if (pauseCanvas.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void ReturnMainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart ()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
