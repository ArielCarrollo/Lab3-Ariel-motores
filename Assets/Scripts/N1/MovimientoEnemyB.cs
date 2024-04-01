using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemyB : EnemyManager
{
    void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (transform.position.y <= downLimit)
        {
            directionY = 1;
        }
        else if (transform.position.y >= upLimit)
        {
            directionY = -1;
        }
        _compRigidBody2D.velocity = new Vector2(0, directionY * Speed);
    }
}
