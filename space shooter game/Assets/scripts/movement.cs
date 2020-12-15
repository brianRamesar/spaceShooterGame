using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 1f;
    Rigidbody2D rb;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

     
    }

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xMove, rb.velocity.y).normalized * speed;

        bool rightPress = Input.GetKeyDown("d");

    }

   
}
