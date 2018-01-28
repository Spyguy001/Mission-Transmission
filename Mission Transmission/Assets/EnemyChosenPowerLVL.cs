using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChosenPowerLVL : MonoBehaviour
{
    public UnityEngine.UI.Text t;
    public int energy = 1;


    void Start()
    {
        //Text sets your text to say this message
        t = GetComponent<UnityEngine.UI.Text>();
        t.text = "Chosen Power: ";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            energy = 1;
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            energy = 2;
        }
        else if (Input.GetKey(KeyCode.Keypad3))
        {
            energy = 3;
        }
        else if (Input.GetKey(KeyCode.Keypad4))
        {
            energy = 4;
        }
        else if (Input.GetKey(KeyCode.Keypad5))
        {
            energy = 5;
        }
        t.text = "Chosen Power: " + energy.ToString();
    }
}