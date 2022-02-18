using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptText : MonoBehaviour 
{
	public Text textBox;
	
	void Start()
	{
		textBox = GetComponent<Text>();
	}
	
	public void SunText()
	{
		textBox.text = "Sun";
	}
	
	public void Sun2Text()
	{
		textBox.text = "Sun2";
	}
	
	public void MerText()
	{
		textBox.text = "Mercury";
	}
	
	public void VenText()
	{
		textBox.text = "Venus";
	}	
	
	public void EarText()
	{
		textBox.text = "Earth";
	}
	
	public void MooText()
	{
		textBox.text = "Moon";
	}
	
	public void MarText()
	{
		textBox.text = "Mars";
	}
	
	public void JupText()
	{
		textBox.text = "Jupiter";
	}
	
	public void SatText()
	{
		textBox.text = "Saturn";
	}
	
	public void UraText()
	{
		textBox.text = "Uranus";
	}
	
	public void NepText()
	{
		textBox.text = "Neptune";
	}
	
	public void PluText()
	{
		textBox.text = "Pluto";
	}
}
