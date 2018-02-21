using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
private float scrollingSpeed = 2f;

    void Start () {
		
	}
	
	void Update () {
        transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
        if (transform.position.x < -25)
        {
			Destroy(gameObject);
        }
    }
}
