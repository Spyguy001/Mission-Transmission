using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {
    public float speed;
    public int power;
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        power = 5;
        speed = 10;
        rb = GetComponent<Rigidbody2D>();
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
                enemy.power = enemy.power - this.power;
                Destroy(gameObject);
            }
            else if (enemy.power < this.power)
            {
                this.power = this.power - enemy.power;
                Destroy(collision.gameObject);
            }
            else if (enemy.power == this.power)
            {
                if (this.transform.position.x > 0)
                {

                }
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
