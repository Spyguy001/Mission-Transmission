using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWave : MonoBehaviour {
    public float speed;
    public int power;
    public Vector2 startV;

	// Use this for initialization
	void Start () {
        power = 20;
        speed = 10;
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        startV = transform.right;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed;
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
                transform.right = startV;
            }
            else if (enemy.power == this.power)
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
        else if (collision.gameObject.name == "right tower")
        {
            EnemyTower tower = collision.gameObject.GetComponent<EnemyTower>();
            tower.health = tower.health - this.power;
            Destroy(gameObject);
        }
    }
}
