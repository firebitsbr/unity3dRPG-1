using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player") {
			anim.SetTrigger ("Hit");
			GameObject destroyObj = Resources.Load<GameObject> ("Effect/SphereParticle");
			Instantiate (destroyObj, transform.position, Quaternion.identity);
			Destroy (this.gameObject, 2.0f);
			Destroy (GameObject.Find ("SphereParticle(Clone)"), 5.0f);
		}
	}
}
