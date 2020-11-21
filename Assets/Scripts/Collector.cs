﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            collision.gameObject.transform.parent = transform;

            collision.gameObject.SetActive(false);
        }
    }
}
