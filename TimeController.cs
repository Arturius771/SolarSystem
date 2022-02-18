using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour 
{
	public float time;
	
	// Update is called once per frame
	void Update () 
	{
		Time.timeScale = time;
		
		if (time < 1f || time > 50f)
		{
			TimeReset ();
		}
	}
	
	public void IncreaseSpeed ()
	{
		time = time + 1f;
	}
	
	public void DecreaseSpeed ()
	{
		time = time - 1f;
	}
	
	public void TimeReset ()
	{
		time = 1f;
	}
}
