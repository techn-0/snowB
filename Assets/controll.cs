using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour
{

    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boost = 30f;
    [SerializeField] float BSspeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        ResponToBoost();
    }

    void ResponToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boost;
        }
        else
        {
            surfaceEffector2D.speed = BSspeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
    }
}
