using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTower : MonoBehaviour {
    public int health;
    public Slider HealthBar;
	// Use this for initialization
	void Start () {
        this.health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.health <= 0)
        {
            Destroy(gameObject);
        }
	}

    float CalculateHealth()
}
