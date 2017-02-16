using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	public Button easyButton;
	public Button medButton;
	public Button hardButton;

	// Use this for initialization
	void Start () {
		easyButton.onClick.AddListener (startGame);
		medButton.onClick.AddListener (startGame);
		hardButton.onClick.AddListener (startGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGame() {
		SceneManager.LoadScene ("_MainGameScene", LoadSceneMode.Single);
	}
}
