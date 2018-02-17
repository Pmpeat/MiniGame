using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private Animator Anim;
	bool Walk;
	bool Atk;
	public bool PlayerOne;


	public float StartHp;
	public float CurrentHp;
	public float Speed;

	private string horizontal;

	private SpriteRenderer mySprenderrer;
	private Rigidbody2D rb2d;

	private Vector2 moveDirection;
	// Use this for initialization
	void Start () {
		Anim = GetComponent <Animator> ();
		rb2d = GetComponent <Rigidbody2D> ();
		mySprenderrer = GetComponent<SpriteRenderer> ();

		CurrentHp = StartHp;
		horizontal = PlayerOne ? "HorizontalP1" : "HorizontalP2";

		if (!PlayerOne) {
			mySprenderrer.flipX = true;
		}
	}

	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis(horizontal);
		moveDirection = new Vector2 (h, 0);
		Walk = (h != 0) ? true : false;


		if ((PlayerOne && Input.GetKeyDown (KeyCode.J)) ||
			!PlayerOne && Input.GetKeyDown (KeyCode.Keypad2)) {
			Atk = true;
		} else {
			Atk = false;
		}






		//Animation

		if (Walk == true) {
			Anim.SetBool ("IsWalk", true);
			Anim.SetBool ("IsIdle", false);
		} else {
			Anim.SetBool ("IsWalk", false);
			Anim.SetBool ("IsIdle", true);
		}
		if (Atk == true) {
			Anim.SetBool ("IsAttack",true);
			Anim.SetBool ("IsIdle", false);
		} else {
			Anim.SetBool ("IsAttack", false);
			Anim.SetBool ("IsIdle", true);
		}

	}

	void FixedUpdate() // Update is called multiple times per frame for PHYSICS
	{
		if (moveDirection.magnitude > 0) {
			rb2d.MovePosition ((Vector2)transform.position + (moveDirection * Speed * Time.deltaTime));
		}
	}

	public void ApplyDamage(int amount){
		CurrentHp -= amount;

		if(CurrentHp <= 0){
			Debug.Log ("Death!!!");
		}
	}

		
}
