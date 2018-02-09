using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody player; 
	public Transform tr;
	public int forceInFwdDirection = 20;

	// Update is called once per frame
	void FixedUpdate () {
		player.AddForce (forceInFwdDirection * Time.deltaTime ,0,0);

		if(Input.GetKey(KeyCode.A) )
			player.AddForce (0,0,10);

		if(Input.GetKey(KeyCode.D) )
			player.AddForce (0,0,-10);

		if(Input.GetKey(KeyCode.W) )
			player.AddForce (10,0,0);
		
		if(Input.GetKey(KeyCode.S) )
			player.AddForce (-10,0,0);

	}
}
