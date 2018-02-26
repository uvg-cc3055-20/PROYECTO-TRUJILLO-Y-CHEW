using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mexicano : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;
	int contador; 
	

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
		
		
	void Update () {
		if(GameController.instance.gameOver == false){
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
	  }
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameController.instance.score++;
		GameController.instance.score += 1;
		Debug.Log (GameController.instance.score);
		contador = contador +1; 
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameController.instance.gameOver = true; 
		SceneManager.LoadScene("perdiste");
	}
	
	public void Awake(){
	rb = GetComponent<Rigidbody2D>();
	contador = 0;
	}


}
