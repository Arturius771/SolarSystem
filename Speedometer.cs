using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour 
{
	
	//For calculating speed
	public float velocity;		
	private Vector3 oldPosition;
	
	//For measuring acceleration
	private float oldVelocity;
	public float acceleration = 0.000000000f;
	
	//for measuring force
	//public Vector3 forceMeasure;
	
	void Update ()
	{
		velocity = ((transform.position - oldPosition).magnitude) / Time.fixedDeltaTime;
		acceleration = (velocity - oldVelocity) / Time.fixedDeltaTime;
		//forceMeasure = new Vector3 (targetSpeed.x, targetSpeed.y, targetSpeed.z);
	}
	
	void FixedUpdate () 
	{
		oldPosition = transform.position;
		oldVelocity = velocity;
	}
}
