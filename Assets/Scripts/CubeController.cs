using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player") {
			GameObject myCube = GameObject.Find ("Cube");
			myCube.GetComponent<Renderer> ().material.color = Color.red;
			this.anim.SetTrigger ("Hit");
			Destroy (gameObject, 3.0f);
		}
	}
}
