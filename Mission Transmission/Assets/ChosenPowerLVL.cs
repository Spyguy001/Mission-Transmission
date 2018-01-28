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
        foreach (char c in Input.inputString)
        {
            int val = (int)System.Char.GetNumericValue(c);
            if(1 <= val && val <= 5)
            {
                energy = val;
            }
        }
        t.text = "Chosen Power: " + energy.ToString();
    }
}
