﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float speed = 1f;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Fixed update
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        myBody.MovePosition(myBody.position + forward * Time.fixedDeltaTime * speed);
    }
}
