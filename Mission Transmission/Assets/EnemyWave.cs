using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour {

    public float speed;
    public int power = 20;
    Rigidbody2D rb;
    public Vector2 startV;
    //public float startZ;

    // Use this for initialization
    void Start()
    {
        power = GameObject.Find("eShooter").GetComponent<EnemyShooter>().ChosenPower ;
        speed = 10;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        startV = transform.right;
        //startZ = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        rb.freezeRotation = true;
        GetComponent<Rigidbody2D>().velocity = startV * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerShot")
        {
            rb.freezeRotation = false;
            transform.right = startV;
            rb.freezeRotation = true;
            //transform.Rotate(Vector3.right, startZ - transform.rotation.z);
        }
        else if (collision.gameObject.name == "left tower")
        {
            PlayerTower tower = collision.gameObject.GetComponent<PlayerTower>();
            tower.health = tower.health - this.power;
            Destroy(gameObject);
        }
    }
}
