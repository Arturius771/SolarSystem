using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailToggle : MonoBehaviour 
{	
	TrailRenderer trailToggle;

	// Use this for initialization
	void Start () 
	{
		trailToggle = GetComponent<TrailRenderer>();
	}
	
	public void Trail()
	{
		trailToggle.enabled = !trailToggle.enabled;
	}
}
