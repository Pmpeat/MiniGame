using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	///<summary>Placeholder delegate function for our buttonList</summary>
	public delegate void ButtonAction();

	public MyButton[] buttonList;

	public int playerOneNumber = 0;

	void Start()
	{
		
		buttonList = new MyButton[3];

		/*buttonList[0].image = GameObject.Find("StartButton").GetComponent<Image>();
		buttonList[0].image.color = Color.yellow;
		buttonList[0].action = PlayButtonAction;

		buttonList[1].image = GameObject.Find("ExitButton").GetComponent<Image>();
		buttonList[1].image.color = Color.white;
		buttonList[1].action = OptionsButtonAction;*/

		buttonList[0].image = GameObject.Find("CharBook").GetComponent<Image>();
		buttonList[0].image.color = Color.yellow;
		buttonList[0].action = PlayButtonAction;

		buttonList[1].image = GameObject.Find("CharMakee").GetComponent<Image>();
		buttonList[1].image.color = Color.white;
		buttonList[1].action = PlayButtonAction;

		buttonList[2].image = GameObject.Find("ComingSoon").GetComponent<Image>();
		buttonList[2].image.color = Color.white;
		buttonList[2].action = PlayButtonAction;
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.D))
		{
			MoveToNextButton();
		}
		else if(Input.GetKeyDown(KeyCode.A))
		{
			MoveToPreviousButton();
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			buttonList[playerOneNumber].action();
		}
	}

	void MoveToNextButton()
	{

		buttonList[playerOneNumber].image.color = Color.white;

		playerOneNumber++;

		if(playerOneNumber >= buttonList.Length)
		{
			
			playerOneNumber = 0;

		}

		buttonList[playerOneNumber].image.color = Color.yellow;
	}

	void MoveToPreviousButton()
	{

		buttonList[playerOneNumber].image.color = Color.white;
		playerOneNumber--;
		if(playerOneNumber < 0)
		{
			playerOneNumber = (buttonList.Length - 1);
		}
		buttonList[playerOneNumber].image.color = Color.yellow;
	}


	void PlayButtonAction()
	{
		Debug.Log("Play");
	}


	void OptionsButtonAction()
	{
		Debug.Log("Options");
	}


	[System.Serializable]
	public struct MyButton
	{
		/// <summary>The image contained in the button.</summary>
		public Button button;
		public Image image;
		/// <summary>The delegate method to invoke on action.</summary>
		public ButtonAction action;
	}
}
