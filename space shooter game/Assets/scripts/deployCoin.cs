using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoin : MonoBehaviour
{

    public GameObject coinPrefab;
    public GameObject p1;
    public GameObject p2;
    float pos;

    public float secondsBetSpawn;
    public float elapsedTime = 0.0f;

    void Start()
    {
     
    }


    private void Update()
    {
        float pos = Random.Range(p1.transform.position.x, p2.transform.position.x);

        elapsedTime += Time.deltaTime;

        if(elapsedTime > secondsBetSpawn)
        {
            elapsedTime = 0;

            Instantiate(coinPrefab, new Vector3(pos, 7, 8), Quaternion.identity);
        }

        
    }
   
}
