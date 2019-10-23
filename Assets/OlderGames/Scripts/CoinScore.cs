using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    [SerializeField]private Text coinLabel;
    private int coin = 0;

    void Start()
    {
        //PlayerPrefs.SetInt("coin", 0);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            //other.gameObject.SetActive(false);
            other.GetComponent<SpriteRenderer>().enabled = false;
            coin++;
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 1);
            coinLabel.text = coin.ToString();
        }    
    }
}
