using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoin : MonoBehaviour
{

    public GameObject coinPrefab;
    public float respawnTime = 1.0f;

    void Start()
    {
        
    }


    private void Update()
    {
        Instantiate(coinPrefab, new Vector3(-2, 6, 8), Quaternion.identity);
    }
   
}
