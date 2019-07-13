﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InterdimensionalTransport : MonoBehaviour {

	public Material[] materials;
	void Start () 
	{
		foreach(var mat in materials)
		{
			mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.name != "Main Camera")
			return;

		if(transform.position.z > other.transform.position.z)
		{	
			Debug.Log("Outside of other world");
			foreach(var mat in materials)
			{
				mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
			}
		}
		
		else
		{
			Debug.Log("Inside other world");
			foreach(var mat in materials)
			{
				mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
			}
		}
	}	

	void onDestroy()
	{
		foreach(var mat in materials)
		{
			mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
		}
	}

	void Update () 
	{
		
	}
}
