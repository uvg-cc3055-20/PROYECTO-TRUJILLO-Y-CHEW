using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
 float scrollingSpeed = 3f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(-1f, 0) * scrollingSpeed * Time.deltaTime);
		if (transform.position.x < -123.16f) {
			transform.position = new Vector3(transform.position.x+ (4*39.4f), transform.position.y, transform.position.z);
			scrollingSpeed= scrollingSpeed +2; 
		}
	}
}
