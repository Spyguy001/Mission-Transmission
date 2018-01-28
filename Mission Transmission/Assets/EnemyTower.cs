using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTower : MonoBehaviour {
    public int health;
    public float energy;
    public int regenRate;
    public Slider HealthBar;
    public Slider TransmissionBar;
    // Use this for initialization
    void Start()
    {
        this.health = 25;
        this.regenRate = 1;
        this.energy = 0;
        this.TransmissionBar.value = 0;
        HealthBar.value = this.health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            if (energy > 0)
            {
                TransmissionBar.value += 1;
                energy -= 1;
            }
        }
        this.energy += Time.deltaTime * this.regenRate;
        HealthBar.value = this.health;
        if (this.health <= 0)
        {
            Destroy(gameObject);
            GameManScript.instance.Win();
        }
        if (this.TransmissionBar.value >= 50)
        {
            Destroy(GameObject.Find("left tower"));
        }
    }

    public bool Fire(int power)
    {
        if (this.energy >= power)
        {
            this.energy -= power;
            return true;
        }
        return false;
    }
}
