using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    [SerializeField] GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Vector3 spawnedPos = new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(-10f, 10f));
            //Vector3 spawnedRot = Vector3.up * Random.Range(0f, 360f);

            // Instantiate(cube, spawnedPos, Quaternion.Euler(spawnedRot));
            // Instantiate(cube, spawnedPos, Quaternion.identity);

            GameObject newCube = Instantiate(cube, spawnedPos, Quaternion.identity) as GameObject;

            newCube.transform.parent = transform;
        }
    }
}
