﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	void Start () 
	{
		
	}
	
	void Update () 
	{
		transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	}
}
