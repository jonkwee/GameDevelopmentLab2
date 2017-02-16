using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

	public float speed = 1f;

	// Use this for initialization
	void Start () {
		speed = PlayerPrefs.GetFloat ("speed");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-1, 0, 0) * speed;
		if (transform.position.x < -9f) {
			Destroy (gameObject);
		}
	}
}
