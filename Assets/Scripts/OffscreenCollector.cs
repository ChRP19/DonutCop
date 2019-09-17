using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collector")
        {
            gameObject.SetActive(false);
        }
    }
}
