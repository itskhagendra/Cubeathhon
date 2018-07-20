using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

	public Rigidbody player;
	public float ForwardForce = 2000f;
	public float SideWays = 500f;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void FixedUpdate () {
		player.AddForce(0,0,ForwardForce*Time.deltaTime);

		if(Input.GetKey("a"))
		{
			player.AddForce(-SideWays*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("d"))
		{
			player.AddForce(SideWays*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("space"))
		{
			player.AddForce(0,SideWays*Time.deltaTime,0,ForceMode.VelocityChange);
		}

	}
}
