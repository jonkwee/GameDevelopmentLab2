using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject broom;

	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - broom.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = broom.transform.position + offset;
	}
}
