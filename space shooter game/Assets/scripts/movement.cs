using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 diretion;
    public float moveSpeed = 1f;

    public float rotateSpeed = 1f;
    Rigidbody2D rb;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            touchPosition.y = 0;
            diretion = (touchPosition - transform.position);
            rb.velocity = new Vector2(diretion.x, 0) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
         
        }
    }
}
