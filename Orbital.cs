using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbital : MonoBehaviour 
{
	//To rotate to face an object
	public Transform parent;	
	
	//Required for the physics to work	
	public Rigidbody rb;
	public float gravConstant;
	public static List<Orbital> Attractors;
	private Vector3 velocity;	
	
	//Initialise the behaviour of the object
	public Vector3 targetOrbitalVelocity;
	public Vector3 constantForce;
	public Vector3 startForce;
	public Vector3 rotateSpeed;	
	
	//For gravity to pull on objects
	private float attractionForce;		
	private Vector3 attraction;	
	

	void Start ()
	{
		Velocity();	
	}
	
	void FixedUpdate()
    {
	   foreach (Orbital attract in Attractors)
	   {
			if (attract != this)
				Attract(attract);
	   }
	   
	   
	   //this applies a given force every fixed update	  
	   rb.AddRelativeForce(constantForce);	   
	   
	   
	   //Rotates at a given rate
	   transform.Rotate (rotateSpeed);	   
	   
	   
	   //Rotates to look at a given object
	   transform.LookAt(parent);
    }	
	
	//OnDisable and OnEnable are a more effecient way of finding objects in the scene to move towards
	void OnEnable ()		
	{
		if (Attractors == null)
			Attractors = new List<Orbital>();
			
		Attractors.Add(this);
	}
	
	void OnDisable ()
	{
		Attractors.Remove(this);
	}
	
	//This is responsible for all the physics enabled bodies attracting each other	
    void Attract(Orbital objToAttract)		
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
		
		if (distance == 0f)
		{
			return;
		}

        attractionForce = gravConstant * (rb.mass*rbToAttract.mass) / Mathf.Pow(distance, 2);
        attraction = direction.normalized*attractionForce;

        rbToAttract.AddForce(attraction);
    }		
	
	//This sets the initial velocity of an object in UU / time
	void Velocity ()	
	{	
		//this converts the real world velocity and scales it down 510 times for this simulation
		velocity = targetOrbitalVelocity / 510.77586f;
		
		//This is the calculation used by the physics engine to apply velocity, scaling with gravConstant
		rb.AddRelativeForce(velocity * Mathf.Pow (gravConstant, .498f), ForceMode.VelocityChange);	
		
		//If I want to add a random force at the start
		rb.AddRelativeForce(startForce);
	}
	
}