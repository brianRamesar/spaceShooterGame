using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienMovement : MonoBehaviour
{
    public int health;

    public GameObject bombPrefab;
    public Transform enemyCanon;

    private float timeBetShots;
    public float startTimeBetShots;

    public Material matRed;
    private Material matDefault;

    private Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        matDefault = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        //moves alien ship down to Y 3
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 3f, 8f),
            2f * Time.deltaTime);

        //if posittion is Y 3, spawn bomb
        if(transform.position.y == 3f)
        {

            if (timeBetShots <= 0)
            {
                Instantiate(bombPrefab, enemyCanon.position, enemyCanon.rotation);
                timeBetShots = startTimeBetShots;
            }
            else
            {
                timeBetShots -= Time.deltaTime;
            }

        }

    }

    private void matReset()
    {
        rend.material = matDefault;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
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
