using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        // Get the rigidbody component
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();

        // Make the bullet move upward
        r2d.velocity = new Vector3(10 , 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
