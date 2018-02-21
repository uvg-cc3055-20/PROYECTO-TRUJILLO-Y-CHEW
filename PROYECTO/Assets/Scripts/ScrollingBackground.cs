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
		transform.Translate(new Vector2(-1, 0) * scrollingSpeed * Time.deltaTime);
		if (transform.position.x < -203.82f) {
			transform.position = new Vector3(203.82f, transform.position.y, transform.position.z);
		}
	}
}
