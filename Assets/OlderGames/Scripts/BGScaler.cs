using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;

        if (gameObject.name == "Build" || gameObject.name == "BG")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        else
            transform.localScale = new Vector3(20.0f, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
