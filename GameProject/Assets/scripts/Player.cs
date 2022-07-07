using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//controls how fast the player moves
	public float moveSpeed = 10.0f;

	public Rigidbody2D player;

	// Use this for initialization
	void Start () {
		player = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		MovePlayer();
	
	}
	//this function allows for the player to move
	public void MovePlayer()
	{
		player.velocity = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

	}
}
