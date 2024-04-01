using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : EnemyManager
{
    void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (transform.position.x <= leftLimit)
        {
            directionX = 1;
        }
        else if (transform.position.x >= rightLimit)
        {
            directionX = -1;
        }
        _compRigidBody2D.velocity = new Vector2(directionX * Speed, 0);
    }
}

