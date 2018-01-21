using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

	public GameObject door;
	public GUI text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			OnMouseDown ();
		}

	}

	void OnMouseDown(){
		// this object was clicked - do something
		Destroy (this.gameObject);
	}   
}
