﻿using UnityEngine;
using System.Collections;

public class SomeAwesomeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("what a silly script");
		GameObject.CreatePrimitive(PrimitiveType.Sphere);
		Transform t = GameObject.Find("Directional Light").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
