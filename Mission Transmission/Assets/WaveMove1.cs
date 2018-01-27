using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove1 : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var rb = GetComponent<Rigidbody2D>();
        var v = new Vector2(Input.GetAxis("Horizontal") * 10, Input.GetAxis("Vertical") * 10);
        rb.velocity = v;
	}
}
