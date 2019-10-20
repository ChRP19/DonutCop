using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinActivator : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    void Update() 
    {
        if (Coin.activeSelf == false)
        {
            StartCoroutine(Active());
        }
    }

    IEnumerator Active()
    {
        yield return new WaitForSeconds(2);
        //this.gameObject.SetActive(true);
        Coin.GetComponent<SpriteRenderer>().enabled = true;
    }
}
