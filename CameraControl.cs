using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour 
{	
	public GameObject sunCam1;
	public GameObject sunCam2;
	public GameObject merCam1;
	public GameObject venCam1;
	public GameObject earCam1;
	public GameObject mooCam1;
	public GameObject marCam1;
	public GameObject jupCam1;
	public GameObject satCam1;
	public GameObject uraCam1;
	public GameObject nepCam1;
	public GameObject pluCam1;
	
	public GameObject sun;
	public GameObject mer;
	public GameObject ven;
	public GameObject ear;
	public GameObject moo;
	public GameObject mar;
	public GameObject jup;
	public GameObject sat;
	public GameObject ura;
	public GameObject nep;
	public GameObject plu;
	
	AudioSource music;
	
	public GameObject active;
	public GameObject lookTarget;
	
	public Camera camera;
	
	//====================================================================================
	//Camera Options Here
	
	void Start()
	{
		camera.fieldOfView = 90f;
	}
	
	void FixedUpdate()
	{
		this.transform.position = active.transform.position;		
	}
	
	void Update()
	{
		transform.LookAt(lookTarget.transform);
		music = GetComponent<AudioSource>();
		
		FieldOfView();
	}
	
	public void Sun()
	{
		active = sunCam1;
		lookTarget = sun;
	}
	
	public void Sun2()
	{
		active = sunCam2;
		lookTarget = sun;
	}
	
	public void Mercury()
	{
		active = merCam1;
		lookTarget = mer;
	}
	
	public void Venus()
	{
		active = venCam1;
		lookTarget = ven;
	}
	
	public void Earth()
	{
		active = earCam1;
		lookTarget = ear;
	}
	
	public void Moon()
	{
		active = mooCam1;
		lookTarget = moo;
	}
	
	public void Mars()
	{
		active = marCam1;
		lookTarget = mar;
	}
	
	public void Jupiter()
	{
		active = jupCam1;
		lookTarget = jup;
	}
	
	public void Saturn()
	{
		active = satCam1;
		lookTarget = sat;
	}
	
	public void Uranus()
	{
		active = uraCam1;
		lookTarget = ura;
	}
	
	public void Neptune()
	{
		active = nepCam1;
		lookTarget = nep;
	}
	
	public void Pluto()
	{
		active = pluCam1;
		lookTarget = plu;
	}
	
	public void Music()
	{
		music.enabled = !music.enabled;
	}
	
	void FieldOfView()
	{
		if (Input.GetKey(KeyCode.W))
		{
			camera.fieldOfView = camera.fieldOfView - 1f;
			
			if(camera.fieldOfView < 1f)
			{
				camera.fieldOfView = 1f;
			}
		}
		
		else if (Input.GetKey(KeyCode.S))
		{
			camera.fieldOfView = camera.fieldOfView + 1f;
			
			if(camera.fieldOfView > 90f)
			{
				camera.fieldOfView = 90f;
			}
		}
	}
}
