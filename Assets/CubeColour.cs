using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var newColour = new Color(Random.Range((float)0.0, (float)(1.0)), Random.Range((float)0.0, (float)(1.0)), Random.Range((float)0.0, (float)(1.0)));
		this.GetComponent<Renderer>().material.color = newColour;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
