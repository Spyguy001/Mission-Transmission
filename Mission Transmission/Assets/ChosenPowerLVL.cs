using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChosenPowerLVL : MonoBehaviour {
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

        if (Input.GetKey(KeyCode.Alpha1))
        {
            energy = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            energy = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            energy = 3;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            energy = 4;
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            energy = 5;
        }
        t.text = "Chosen Power: " + energy.ToString();
    }
}
