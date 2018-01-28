using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShooterScript : MonoBehaviour {
    public GameObject MyShot;
    public Slider EnergyBar;
    public Slider ChosenPower;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        
        // Get the rigidbody component
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();

        // Move the square when an arrow key is pressed
        if (Input.GetKey(KeyCode.W))
            r2d.velocity = new Vector3(0, 10, 0);
        else if (Input.GetKey(KeyCode.S))
            r2d.velocity = new Vector3(0, -10, 0);
        else
            r2d.velocity = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            

            if (GameObject.Find("left tower").GetComponent<PlayerTower>().Fire(GameObject.Find("chosen power").GetComponent<ChosenPowerLVL>().energy))
            {
                
            Instantiate(MyShot, transform.position, Quaternion.identity);
            }
        }
 


    }
}
