using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_movement2 : MonoBehaviour {
	float timeCounter=0;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {




		timeCounter += (Time.deltaTime);
		float x = Mathf.Sin (timeCounter);
		float y = (Mathf.Cos (timeCounter)) ;
		float z = -14;

		transform.position = new Vector3 (x, y, z);
		/*

        timeCounter += (Time.deltaTime);
        float x = Mathf.Tan (timeCounter);
        float y = (Mathf.Cos (timeCounter)) + 4;
        float z = 0;

        transform.position = new Vector3 (x, y, z);
*/



	}







}

