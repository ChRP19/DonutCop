using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject UIController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Barrier")
        {
            UIController.GetComponent<UIController>().RestartGame();
        }
    }

}
