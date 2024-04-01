using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Rigidbody2D _compRigidBody2D;
    public float Speed = 5;
    public float leftLimit;
    public float rightLimit;
    public float downLimit;
    public float upLimit;
    public int directionX = 1;
    public int directionY = 1;
}
