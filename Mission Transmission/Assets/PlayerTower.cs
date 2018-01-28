using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTower : MonoBehaviour {

    public int health;
    public float energy;
    public int regenRate;
    public Slider HealthBar;
    public Slider TransmissionBar;

    public int progress;
    // Use this for initialization
    void Start()
    {
        this.health = 100;
        this.regenRate = 1;
        this.energy = 0;
        this.progress = 0;
        HealthBar.value = this.health;
        TransmissionBar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.energy += Time.deltaTime * this.regenRate;
        HealthBar.value = this.health;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (energy > 0)
            {
                TransmissionBar.value += 1;
                energy -= 1;
            }
        }
        if (this.health <= 0)
        {
            Destroy(gameObject);
            GameManScript.instance.Win();
        }
        if (this.progress >= 100)
        {
            Destroy(GameObject.Find("right tower"));
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
