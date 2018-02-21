using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner1_1 : MonoBehaviour {

public GameObject enemy2t; 
float SpawnTime = 9f; 
float elapsedTime = 6f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (elapsedTime < SpawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else {
            float random = Random.Range(0.5f, 0.5f);
            Instantiate(enemy2t, new Vector3(8, random, 0), Quaternion.identity);
            elapsedTime = 0;
        }
	}
}
