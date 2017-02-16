using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BroomScript : MonoBehaviour {

	public GameObject obstacle;



	// Use this for initialization
	void Start () {
		transform.localEulerAngles = new Vector3 (-56f, -137f, 46f);

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (0f, 0f, 1f) * 0.5f;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.position -= new Vector3 (0f, 0f, 1f) * 0.5f;
		}

		transform.localEulerAngles = new Vector3 (-56f, -137f, 46f);
			
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Obstacle(Clone)") {
			Destroy (gameObject);
			SceneManager.LoadScene ("_GameOverScene", LoadSceneMode.Single);
		}
	}
}
