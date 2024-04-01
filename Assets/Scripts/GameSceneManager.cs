using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public string Scena;
    public void CambiodeScena(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
