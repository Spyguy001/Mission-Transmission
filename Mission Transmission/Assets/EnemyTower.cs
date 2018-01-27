using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTower : MonoBehaviour {
    public int health;

    // Use this for initialization
    void Start()
    {
        this.health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
