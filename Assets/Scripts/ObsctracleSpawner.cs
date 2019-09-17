using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsctracleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    public List<GameObject> obstraclesToSpawn = new List<GameObject>();

    int index;

    void Awake()
    {
        InitPlatforms();
    }

    void Start()
    {
        StartCoroutine(SpawnRandomPlatforms());
    }

    void InitPlatforms()
    {
        index = 0;
        for (int i = 0; i < platforms.Length * 3; i++)
        {
            GameObject obj = Instantiate(platforms[index], transform.position, Quaternion.identity);
            obstraclesToSpawn.Add(obj);
            obstraclesToSpawn[i].SetActive(false);
            index++;

            if (index == platforms.Length)
            {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomPlatforms()
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 4.5f));

        int index = Random.Range(0, obstraclesToSpawn.Count);

        while(true)
        {
            if (!obstraclesToSpawn[index].activeInHierarchy)
            {
                obstraclesToSpawn[index].SetActive(true);
                obstraclesToSpawn[index].transform.position = transform.position;
                break;
            } else
            {
                index = Random.Range(0, obstraclesToSpawn.Count);
            }
        }
        StartCoroutine(SpawnRandomPlatforms());
    }
}
