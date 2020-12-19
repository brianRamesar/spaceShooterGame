using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemyInstance;

    public GameObject p1;
    public GameObject p2;
    private float pos;

    public float secondsBetSpawn;
    public float elapsedTime = 0.0f;

    void Start()
    {

    }


    private void Update()
    {
        pos = Random.Range(p1.transform.position.x, p2.transform.position.x);
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetSpawn)
        {
            elapsedTime = 0;

            spawnEnemy();

            

        }
   
    }

    private void spawnEnemy()
    {
        enemyInstance = Instantiate(enemyPrefab, new Vector3(pos, 7, 8), Quaternion.identity);


    }

}
