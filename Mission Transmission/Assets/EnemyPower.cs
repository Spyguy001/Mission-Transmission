using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPower : MonoBehaviour
{
    public UnityEngine.UI.Text eT;

    void Start()
    {
        //Text sets your text to say this message
        eT = GetComponent<UnityEngine.UI.Text>();
        eT.text = "Available Power: ";
    }

    void Update()
    {
        int energy = (int)GameObject.Find("right tower").GetComponent<EnemyTower>().energy;
        eT.text = "Available Power: " + energy.ToString();
    }
}
