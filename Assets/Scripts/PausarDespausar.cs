using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarDespausar : MonoBehaviour
{
    public GameObject pauseMenu;
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}


