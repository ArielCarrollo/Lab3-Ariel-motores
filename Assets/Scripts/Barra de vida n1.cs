using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra_de_vida_n1 : MonoBehaviour
{
    public GameObject Vidaplayer;
    public Sprite[] _sprite;
    public Image _spriteRenderer;
    void Awake()
    {
        _spriteRenderer = GetComponent<Image>();
        GameManager.PlayerDamaged += UpdatePlayerUI;
    }
    void OnDisable()
    {
        GameManager.PlayerDamaged -= UpdatePlayerUI;
    }
    void UpdatePlayerUI()
    {
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 10)
        {
            _spriteRenderer.sprite = _sprite[9];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 9)
        {
            _spriteRenderer.sprite = _sprite[0];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 8)
        {
            _spriteRenderer.sprite = _sprite[1];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 7)
        {
            _spriteRenderer.sprite = _sprite[2];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 6)
        {
            _spriteRenderer.sprite = _sprite[3];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 5)
        {
            _spriteRenderer.sprite = _sprite[4];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 4)
        {
            _spriteRenderer.sprite = _sprite[5];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 3)
        {
            _spriteRenderer.sprite = _sprite[6];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 2)
        {
            _spriteRenderer.sprite = _sprite[7];
        }
        if (Vidaplayer.GetComponent<CONTROLES>().Vidas == 1)
        {
            _spriteRenderer.sprite = _sprite[8];
        }
    }
}
