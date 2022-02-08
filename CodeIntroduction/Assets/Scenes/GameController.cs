using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cubePrefab;
    public int cubeAmount = 10;
    public float randomArea = 10f;

    void Start()
    {
        int i = 0;
        while (i < cubeAmount)
        {
            GameObject cubeObject = Instantiate (cubePrefab);
            cubeObject.transform.position = new Vector3(Random.Range(-randomArea, randomArea), Random.Range(-randomArea, randomArea), 0);
            i++;
        }
    }

    void Update()
    {
        
    }
}
