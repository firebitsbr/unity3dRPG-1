using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemController : MonoBehaviour {
	public Item.ItemType itemType;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Player") {
			print (other.name);
			GameManager.instance.inventory.AddItem (itemType);
			Destroy (gameObject);
		}
	}
}
