using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    public float distance;
    public int damage;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance);

        if(hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("enemy"))
            {
                DestroyProjectile();

                hitInfo.collider.GetComponent<alienMovement>().takeDamage(damage);
            }
        }



        

        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
