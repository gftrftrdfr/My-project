using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;   

    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomSpawnPosition = new Vector3(0, Random.Range(10, 20), 0);
        Instantiate(cube, randomSpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-50, 50), Random.Range(10, 10 + 19120402 % 10), Random.Range(-50, 50));
            Instantiate(sphere, randomSpawnPosition, Quaternion.identity);
        }
    }
}
