using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienMovement : MonoBehaviour
{
    public int health;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 3f, 8f),
            2f * Time.deltaTime);


        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        health -= damage;
    }

}
