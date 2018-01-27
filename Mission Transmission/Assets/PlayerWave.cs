using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWave : MonoBehaviour {
    public float speed;
    public int power;

	// Use this for initialization
	void Start () {
        power = 5;
        speed = 10;
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "EnemyShot")
        {
            EnemyWave enemy = collision.gameObject.GetComponent<EnemyWave>();
            if (enemy.power > this.power)
            {
                Destroy(gameObject);
            }
            else if (enemy.power < this.power)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                print("Enemy hit");
            }
        }
        else if (collision.gameObject.name == "PlayerShot")
        {

        }
        else if (collision.gameObject.name == "right tower")
        {
            print("tower hit");
        }
    }
}
