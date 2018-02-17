using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageP : MonoBehaviour {

	public float Damagep;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D coll){
		if(coll.gameObject.tag == "Player2"){
			coll.gameObject.SendMessage("ApplyDamage", 10);
		}
	}
}
