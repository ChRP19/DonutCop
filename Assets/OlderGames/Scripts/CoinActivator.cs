using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinActivator : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    void Update() 
    {
        if (Coin.GetComponent<SpriteRenderer>().enabled == false)
        {
            StartCoroutine(Active());
        }
    }

    IEnumerator Active()
    {
        yield return new WaitForSeconds(2);
        Coin.GetComponent<SpriteRenderer>().enabled = true;
    }
}
