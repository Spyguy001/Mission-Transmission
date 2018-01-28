using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour {
    public GameObject MyShot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        
        // Get the rigidbody component
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();

        // Move the spaceship when an arrow key is pressed
        if (Input.GetKey(KeyCode.W))
            r2d.velocity = new Vector3(0, 10, 0);
        else if (Input.GetKey(KeyCode.S))
            r2d.velocity = new Vector3(0, -10, 0);
        else
            r2d.velocity = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(MyShot, transform.position, Quaternion.identity);
        }
 


    }
}
