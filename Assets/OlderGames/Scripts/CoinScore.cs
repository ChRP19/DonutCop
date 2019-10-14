using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    [SerializeField]private Text coinLabel;
    private int coin = 0;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coin++;
            coinLabel.text = coin.ToString();
        }    
    }
}
