using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour {
    public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay( Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(levelToLoad);
        }
	}
}
