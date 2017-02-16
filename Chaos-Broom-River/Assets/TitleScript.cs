using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

	private float easySpeed = 0.25f;
	private float medSpeed = 1f;
	private float hardSpeed = 2.5f;

	public Button easyButton;
	public Button medButton;
	public Button hardButton;

	// Use this for initialization
	void Start () {
		easyButton.onClick.AddListener (delegate{startGame(easySpeed);});
		medButton.onClick.AddListener (delegate{startGame(medSpeed);});
		hardButton.onClick.AddListener (delegate{startGame(hardSpeed);});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGame(float s) {
		SceneManager.LoadScene ("_MainGameScene", LoadSceneMode.Single);

		PlayerPrefs.SetFloat ("speed", s);
	}
}
