using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void LoadByIndex(int Scene){
		SceneManager.LoadScene (Scene);
	}

}
