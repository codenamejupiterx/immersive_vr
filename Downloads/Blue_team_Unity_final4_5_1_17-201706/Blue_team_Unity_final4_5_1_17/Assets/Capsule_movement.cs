using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_movement : MonoBehaviour {
	float timeCounter=0;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {




		timeCounter += (Time.deltaTime);
		float x = -14;
		float y = (Mathf.Cos (timeCounter)) + 4;
		float z = -4;

		transform.position = new Vector3 (x, y, z);




	}







}
