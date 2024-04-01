using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static event Action PlayerDamaged;
    public static event Action PlayerDeath;
    public static event Action PlayerVictory;
    public static event Action<int> ScoreUpdated;
    public static void InvokePlayerDamaged()
    {
        PlayerDamaged?.Invoke();
    }
    public static void InvokePlayerDeath()
    {
        PlayerDeath?.Invoke();
    }
    public static void InvokePlayerVictory()
    {
        PlayerVictory?.Invoke();
    }
    public static void InvokeScoreUpdated(int score)
    {
        ScoreUpdated?.Invoke(score);
    }
    public GameObject Player;
    public TextMeshProUGUI Tiempo;
    public TextMeshProUGUI VidasdelPlayer;
    public TextMeshProUGUI Puntajedelplayer;
    public float TimE = 0;
    public float puntos;
    void Update()
    {
        TimE = TimE + Time.deltaTime;
        Tiempo.text = "TIEMPO: " + TimE.ToString("F0");
   }
    void OnEnable()
    {
        PlayerDeath += PlayerLost;
        PlayerVictory += PlayerWin;
        ScoreUpdated += UpdateScoreUI;
    }

    void OnDisable()
    {
        PlayerDeath -= PlayerLost;
        PlayerVictory += PlayerWin;
        ScoreUpdated -= UpdateScoreUI;
    }
    void PlayerWin()
    {
        PlayerPrefs.SetFloat("TiempoGuardado", TimE);
        PlayerPrefs.SetFloat("PuntajeGuardado", puntos);
        PlayerPrefs.Save();
        if (SceneManager.GetActiveScene().name == "nivel 1")
        {
            SceneManager.LoadScene("ganaste");
        }
        else if(SceneManager.GetActiveScene().name == "nivel 2")
        {
            SceneManager.LoadScene("ganaste2");
        }
    }
    void PlayerLost()
    {
        if (SceneManager.GetActiveScene().name == "nivel 1")
        {
            SceneManager.LoadScene("perdiste");
        }
        else if (SceneManager.GetActiveScene().name == "nivel 2")
        {
            SceneManager.LoadScene("perdiste2");
        }
    }

    void UpdateScoreUI(int score)
    {
        puntos = score;
        Puntajedelplayer.text = "Puntos: " + puntos;
    }
}
