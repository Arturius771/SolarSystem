using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandButton : MonoBehaviour 
{
	public GameObject button;
	
	private bool toggle;
	
	// Use this for initialization
	void Start () 
	{
		button = gameObject;
		toggle = false;
	}
	
	public void buttonToggle()
	{
		toggle = !toggle;
		
		if (toggle == false)
		{
			button.SetActive(true);
		}
		
		if (toggle == true)
		{
			button.SetActive(false);
		}
	}
}
