using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 diretion;
    public float moveSpeed = 1f;

    public Transform leftCanon;
    public Transform rightCanon;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

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

            Shoot();

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
         
        }

      void Shoot()
        {
            GameObject leftBullet = Instantiate(bulletPrefab, leftCanon.position, leftCanon.rotation);
            GameObject rightBullet = Instantiate(bulletPrefab, rightCanon.position, leftCanon.rotation);

            Rigidbody2D rigidB = leftBullet.GetComponent<Rigidbody2D>();
            rigidB.AddForce(leftCanon.up * bulletForce, ForceMode2D.Impulse);

            Rigidbody2D rigidBr = rightBullet.GetComponent<Rigidbody2D>();
            rigidBr.AddForce(rightCanon.up * bulletForce, ForceMode2D.Impulse);

            if(leftBullet.transform.position.y > 7)
            {
                Destroy(leftBullet);
            }

            if (rightBullet.transform.position.y > 7)
            {
                Destroy(rightBullet);
            }
        }
    }
}
