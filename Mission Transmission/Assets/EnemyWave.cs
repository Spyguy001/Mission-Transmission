using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour {
    public float speed;
    public int power;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        power = 3;
        speed = 10;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("HA");
    }
}
