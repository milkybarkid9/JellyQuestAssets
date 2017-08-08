﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    [SerializeField]
    public int currentScore = 0;
    [SerializeField]
    public float ballVelocity = 100;
    Rigidbody2D rb;
    bool mapOpen = false;

    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();        
    }

    void Awake()
    {
        //GameObject.Find("GameManager").GetComponent<PositionPlayer>().MoveToStart();
    }
	
	// Update is called once per frame
	void Update () {

        if (!mapOpen)
        {
            rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * ballVelocity, Input.GetAxis("Vertical") * ballVelocity));
        }


        /*if (Input.GetAxis("Vertical") > 0 && mapOpen == false)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(0, ballVelocity, 0));
        }
        if (Input.GetAxis("Vertical") < 0 && mapOpen == false)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(0, -ballVelocity, 0));
        }
        if (Input.GetAxis("Horizontal") > 0 && mapOpen == false)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballVelocity, 0, 0));
        }
        if (Input.GetAxis("Horizontal") < 0 && mapOpen == false)
        {
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(-ballVelocity, 0, 0));
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera.main.orthographicSize = 30;
            mapOpen = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Camera.main.orthographicSize = 5;
            mapOpen = false;
        }
    }
}
