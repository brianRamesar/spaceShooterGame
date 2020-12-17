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
        float h = Input.GetAxis("Horizontal");

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Touch touch = Input.touches[0];
            h = touch.deltaPosition.x;
        }

        if((h > 0 ) || (h < 0))
        {
            Vector3 tempVect = new Vector3(h, 0, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;

            Vector3 newPos = rb.transform.position + tempVect;
            checkBoundary(newPos);
        }
    }

     void checkBoundary(Vector3 newPos)
    {
        Vector3 camViewPoint = Camera.main.WorldToScreenPoint(newPos);

        camViewPoint.x = Mathf.Clamp(camViewPoint.x, 0.04f, 0.96f);

        Vector3 finalPos = Camera.main.ViewportToWorldPoint(camViewPoint);
        rb.MovePosition(finalPos);
    }
}
