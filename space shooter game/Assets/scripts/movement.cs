﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movement : MonoBehaviour
{

    private Vector3 touchPosition;
    private Vector3 diretion;
    public float moveSpeed = 1f;

    public float health;

    public Transform leftCanon;
    public Transform rightCanon;
    public GameObject bulletPrefab;

    public float rotateSpeed = 1f;
    Rigidbody2D rb;

    private float timeBetShots;
    public float startTimeBetShots;

    public Material matRed;
    private Material matDefault;

    private Renderer rend;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rend = GetComponent<Renderer>();
        matDefault = rend.material;
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

            if(timeBetShots <= 0)
            {
                GameObject leftBullet = Instantiate(bulletPrefab, leftCanon.position, leftCanon.rotation);
                GameObject rightBullet = Instantiate(bulletPrefab, rightCanon.position, leftCanon.rotation);
                timeBetShots = startTimeBetShots;
            }
            else
            {
                timeBetShots -= Time.deltaTime;
            }

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
    }

    

    private void matReset()
    {
        rend.material = matDefault;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "enemyBullet")
        {
            health--;

            rend.material = matRed;

            if (health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Invoke("matReset", .1f);
            }
        }
    }
}
