using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoumnSpawner : MonoBehaviour {
public GameObject enemy; 
float SpawnTime = 6f; 
float elapsedTime = 4f; 

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
            float random = Random.Range(-0.5f, -0.5f);
            Instantiate(enemy, new Vector3(8, random, 0), Quaternion.identity);
            elapsedTime = 0;
        }
	}
}
