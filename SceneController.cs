using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour 
{
	public void LoadMain()
	{
		Application.LoadLevel("Main");
	}
	
	public void LoadMenu()
	{
		Application.LoadLevel("Menu");
	}
	
	public void LoadCredits()
	{
		Application.LoadLevel("Credits");
	}
	
}
