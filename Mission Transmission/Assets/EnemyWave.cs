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
        if (collision.gameObject.name == "PlayerShot")
        {
            PlayerWave player = collision.gameObject.GetComponent<PlayerWave>();
            if (player.power > this.power)
            {
                player.power = player.power - this.power;
                Destroy(gameObject);
            }
            else if (player.power < this.power)
            {
                this.power = this.power - player.power;
                Destroy(collision.gameObject);
            }
            else if (player.power == this.power)
            {
                if (this.transform.position.x < 0)
                {
                    print("Enemy In player area, give energy to enemy");
                }
                else if (this.transform.position.x > 0)
                {
                    print("Player In enemy area, give energy to player");
                }
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.name == "left tower")
        {
            PlayerTower tower = collision.gameObject.GetComponent<PlayerTower>();
            tower.health = tower.health - this.power;
            Destroy(gameObject);
        }
    }
}
