using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour {
    public UnityEngine.UI.Text t;

    void Start()
    {
        //Text sets your text to say this message
        t = GetComponent<UnityEngine.UI.Text>();
        t.text = "Available Power: ";
    }

    void Update()
    {
        int energy = (int)GameObject.Find("left tower").GetComponent<PlayerTower>().energy;
        t.text = "Available Power: " + energy.ToString();
    }
}
