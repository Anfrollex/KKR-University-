﻿using UnityEngine;
using System.Collections;

/*[System.Serializable]
public class Boundary {
	public float xMin, xMax, zMin, zMax;
}*/

public class EnemyAI : MonoBehaviour {
	
	public float speed;
	public float tilt;
	//public float armor;

	public int enemyType;
	public GameObject shot;
	public Transform[] shotSpawn;
	
	public float fireRate;
	private float nextFire;
	
	void Update() {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
		
			for(int i=0; i<shotSpawn.Length; i++){
				Instantiate (shot, shotSpawn[i].position, shotSpawn[i].rotation);}
			//GetComponent<AudioSource>().Play();
		}
	}
	
	void FixedUpdate() {
		/*float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3
			(
				Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
				0,
				Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
				);
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);*/
	}
}
