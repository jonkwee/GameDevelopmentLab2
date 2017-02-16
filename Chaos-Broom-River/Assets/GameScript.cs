using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

	public GameObject broom;
	public GameObject obstacle;
	public float distanceFromBroom = 20f;

	public float timeDelay = 1f;
	private float timestamp;

	private float speedChange = 0.8f;
	private float timeInterval = 10f;

	// Use this for initialization
	void Start () {
		timestamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (timestamp < Time.time) {
			createObstacle ();
			timestamp += timeDelay;
		}

		// increase speed after set amount of time
		if (Time.time > timeInterval) {
			timeDelay *= speedChange;
			timeInterval += 10;
		}

	}

	void createObstacle() {
		GameObject obs = Instantiate (Resources.Load ("Obstacle"), new Vector3(distanceFromBroom, broom.transform.position.y, broom.transform.position.z),
			Quaternion.identity) as GameObject;
	}
}
