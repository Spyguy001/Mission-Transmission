using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWave : MonoBehaviour {

    public float speed;
    public int power = 1;
    public Vector2 startV;

    // Use this for initialization
    void Start()
    {
        power = GameObject.Find("chosen power").GetComponent<ChosenPowerLVL>().energy ;
        transform.localScale = new Vector3(0.2f + power * 0.3f, 0.2f + power * 0.3f);
        speed = 10;
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        startV = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        GetComponent<Rigidbody2D>().velocity = startV * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.name == "right tower")
        {
            EnemyTower tower = collision.gameObject.GetComponent<EnemyTower>();
            tower.health = tower.health - this.power;
            Destroy(gameObject);
        }
        else //if (collision.gameObject.name == "EnemyShot(Clone)")
        {
            
            EnemyWave enemy = collision.gameObject.GetComponent<EnemyWave>();
            if (enemy.power > this.power)
            {
                enemy.power = enemy.power - this.power;
                collision.gameObject.GetComponent<Transform>().transform.localScale = new Vector3(0.2f + power * 0.3f, 0.2f + power * 0.3f);
                Destroy(this.gameObject);
            }
            else if (enemy.power < this.power)
            {
                this.power = this.power - enemy.power;
                transform.localScale = new Vector3(0.2f + power * 0.3f, 0.2f + power * 0.3f);
                Destroy(collision.gameObject);
                transform.right = startV;
            }
            else if (enemy.power == this.power)
            {
                if (this.transform.position.x < 0)
                {
                    GameObject.Find("right tower").GetComponent<EnemyTower>().energy++;
                }
                else if (this.transform.position.x > 0)
                {
                    GameObject.Find("left tower").GetComponent<PlayerTower>().energy++;
                }
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        
    }
}
