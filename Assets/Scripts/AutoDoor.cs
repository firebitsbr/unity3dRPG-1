using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour {

	Animator anim;

	public bool conditionNeedItem = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Player") {
			print (other.name + "がぶつかりました");
			if (conditionNeedItem == false) {
				anim.SetBool ("IsOpen", true);
			} else if (GameManager.instance.inventory.HasItem ()) {
				anim.SetBool ("IsOpen", true);
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "Player") {
			anim.SetBool ("IsOpen", false);
		}
	}
}
