using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinPickup : MonoBehaviour
{
    // Start is called before the first frame update
    private float coin = 0;

    private float killCount = 0;

    public TextMeshProUGUI textCoins;
    public TextMeshProUGUI killCounter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "coin")
        {
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
       
    }
}
