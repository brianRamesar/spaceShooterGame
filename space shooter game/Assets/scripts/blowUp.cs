using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowUp : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 7)
        {
            Destroy(gameObject);
        }
    }
}
