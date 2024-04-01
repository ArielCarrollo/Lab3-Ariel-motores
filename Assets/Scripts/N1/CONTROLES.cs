using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;


public class CONTROLES : MonoBehaviour
{
    public int Vidas = 10;
    public int puntaje = 0;
    public Rigidbody2D _compRigidBody2D;
    public SpriteRenderer _Spriterenderer;
    public int velocityModifier = 3;
    public float distanceModifier = 5;
    public LayerMask layermask;
    public int Jumps;
    public int fuerza;
    bool Cred = false;
    bool Cblue = false;
    bool Cgreen = false;
    private void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
        _Spriterenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Saltar();
    }
    void FixedUpdate()
    {
        Movimiento();
        Chequearpiso();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "red" && Cred == false)
        {
            Vidas--;
            GameManager.InvokePlayerDamaged();
            if (Vidas <= 0)
            {
                GameManager.InvokePlayerDeath();
            }
        }
        if (collision.gameObject.tag == "blue" && Cblue == false)
        {
            Vidas--;
            GameManager.InvokePlayerDamaged();
            if (Vidas <= 0)
            {
                GameManager.InvokePlayerDeath();
            }
        }
        if (collision.gameObject.tag == "green" && Cgreen == false)
        {
            Vidas = Vidas - Vidas;
            if (Vidas <= 0)
            {
                GameManager.InvokePlayerDeath();
            }
        }
        if (collision.gameObject.tag == "puntos")
        {
            puntaje++;
            GameManager.InvokeScoreUpdated(puntaje);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "vida" && Vidas <= 10)
        {
            Vidas++;
            GameManager.InvokePlayerDamaged();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "ganaste")
        {
            GameManager.InvokePlayerVictory();
        }
    }
    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumP();
        }
    }
    void Movimiento()
    {
        Vector2 inputVector = new Vector2(Input.GetAxis("Horizontal"), 0);
        _compRigidBody2D.velocity = new Vector2(inputVector.x * velocityModifier, _compRigidBody2D.velocity.y);
        Debug.DrawRay(transform.position, inputVector.normalized * distanceModifier, Color.red);
    }
    void Chequearpiso()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, Vector2.down, distanceModifier, layermask);
        if (raycast)
        {
            if (raycast.collider.CompareTag("Piso"))
            {
                Jumps = 1;
            }
        }
    }
    void JumP()
    {
        if (Jumps > 0)
        {
            _compRigidBody2D.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
            Jumps--;
        }
    }
    public void ColorChangeR()
    {
        Color newColor = new Color(255, 0, 0);
        _Spriterenderer.color = newColor;
        Cred = true;
        Cblue = false;
        Cgreen = false;
    }
    public void ColorChangeB()
    {
        Color newColor = new Color( 0, 0,255);
        _Spriterenderer.color = newColor;
        Cblue = true;
        Cred = false;
        Cgreen = false;
    }
    public void ColorChangeG()
    {
        Color newColor = new Color(0, 255, 0);
        _Spriterenderer.color = newColor;
        Cgreen = true;
        Cblue = false;
        Cred = false;
    }
}
