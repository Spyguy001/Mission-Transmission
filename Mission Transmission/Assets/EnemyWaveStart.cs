using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveStart : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
        speed = 10;
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with something");
    }
}
