using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTower : MonoBehaviour {
    public int health;
    public Slider HealthBar;

    // Use this for initialization
    void Start()
    {
        this.health = 100;
        HealthBar.value = this.health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.value = this.health;
        if (this.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
