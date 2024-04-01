using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gAMEmANAGER2 : GameManager
{
    void Awake()
    {
        if (PlayerPrefs.HasKey("TiempoGuardado"))
        {
            TimE = PlayerPrefs.GetFloat("TiempoGuardado");
        }
    }
    void Update()
    {
        TimE = TimE + Time.deltaTime;
        Tiempo.text = "TIEMPO: " + TimE.ToString("F0");
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("TiempoGuardado2", TimE);
        PlayerPrefs.Save();
    }
}
