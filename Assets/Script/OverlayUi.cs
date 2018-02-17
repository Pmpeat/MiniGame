using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OverlayUi : MonoBehaviour {

	// Use this for initialization
	public Image imgHPProgress;
	public PlayerControl player;
	public Color dangercolor;
	public Sprite col;


	// Use this for initialization

	// Update is called once per frame
	void Update () {
		float hp = this.player.CurrentHp;
		float hpMax = this.player.StartHp;
		float fa = hp / hpMax;
		this.imgHPProgress.fillAmount = fa;

		{
			this.imgHPProgress.sprite = col;

		}
		if(fa <= 0.2f){
			this.imgHPProgress.color = dangercolor;
		}
	}
}

