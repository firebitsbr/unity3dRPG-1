using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	Animation anim;
	BoxCollider boxCollider;
	public int hp = 100;
	Slider slider;
	int attackPower;
	GameObject hpObj;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		boxCollider = GetComponent<BoxCollider> ();
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();
		hpObj = transform.Find ("HP").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		print (other.name);
		if (other.name == "cutter01") {
			attackPower = other.GetComponent<Weapon> ().power;
			hp -= attackPower;
			slider.value = hp;
			print (hp);
			if (hp == 0) {
				anim.Play ("Allosaurus_Die");
				Destroy (boxCollider);
				Destroy (hpObj);
				GameObject destroyObj = Resources.Load<GameObject> ("Effect/SphereParticle");
				Instantiate (destroyObj, transform.position, Quaternion.identity);
				Invoke ("EnemyDead", 5.0f);
				Destroy (GameObject.Find ("SphereParticle(Clone)"), 6.0f);
				Invoke ("ItemDrop", 5.0f);
			}
		}
	}

	void EnemyDead(){
		Destroy (gameObject);
	}

	void ItemDrop(){
		GameObject item = (GameObject)Resources.Load ("key_blonze");
		Instantiate (item, gameObject.transform.position, Quaternion.identity);
	}
}
