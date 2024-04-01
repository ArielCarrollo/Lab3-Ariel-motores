using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ultimomanager : GameSceneManager
{
    public TextMeshProUGUI Tiempo;
    public float TimE = 0;
    void Awake()
    {
        if (PlayerPrefs.HasKey("TiempoGuardado2"))
        {
            TimE = PlayerPrefs.GetFloat("TiempoGuardado2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo.text = "TIEMPO: " + TimE.ToString("F0");
    }
}
