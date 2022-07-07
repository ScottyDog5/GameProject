using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	
	public GameObject projectile;

	public Transform projectileSpawn;

	public float nextFire = 1.0f; //time interval between shots
	public float currentTime = 0.0f; //current time to build up

	// Use this for initialization
	void Start () {
		projectileSpawn = this.gameObject.transform; //make link to where this game object is
	}
	
	// Update is called once per frame
	void Update () {
		
		shoot ();
	}

	//this function allows for projectiles to shoot from the ship
	public void shoot()
	{
		currentTime += Time.deltaTime;
		if(Input.GetButton("Fire1") && currentTime > nextFire) 
		{
			nextFire += currentTime; 
			Instantiate (projectile,projectileSpawn.position, Quaternion.identity);

			nextFire -= currentTime;
			currentTime = 0.0f; 
		}
	}
}
