﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Followed this tutorial: https://www.youtube.com/watch?v=L6Q6VHueWnU

public class Move2D_P1 : MonoBehaviour
{
    public float moveSpeed = 8f;
    public bool isGrounded1 = false;  
    // Start is called before the first frame update
    void Start()
    {
        //Physics.IgnoreLayerCollision(8, 9);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (isGrounded1 == true && Input.GetKey(KeyCode.DownArrow)) {
            gameObject.layer = 10;
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded1 == true) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 19f), ForceMode2D.Impulse);
        }
    }
}
