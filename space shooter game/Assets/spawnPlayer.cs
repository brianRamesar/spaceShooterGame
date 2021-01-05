using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{

    public GameObject playerPrefab;

    public void spawnChar()
    {
        Instantiate(playerPrefab, new Vector3(0, 2, 8), Quaternion.identity);
    }
    

 
}
