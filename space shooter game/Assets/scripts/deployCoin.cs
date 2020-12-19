using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoin : MonoBehaviour
{

    public GameObject coinPrefab;
    public float respawnTime = 1.0f;

    public GameObject p1;
    public GameObject p2;
    float pos;

    void Start()
    {
        
    }


    private void Update()
    {
        float pos = Random.Range(p1.transform.position.x, p2.transform.position.x);

        Instantiate(coinPrefab, new Vector3(pos,7,8), Quaternion.identity);
    }
   
}
