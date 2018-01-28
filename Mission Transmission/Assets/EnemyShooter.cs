using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public GameObject myShot;
    public int ChosenPower;
    public float timeUntilShot;
    // Use this for initialization
    void Start()
    {
        timeUntilShot = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();

        // Move the square when an arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
            r2d.velocity = new Vector3(0, 10, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            r2d.velocity = new Vector3(0, -10, 0);
        else
            r2d.velocity = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            if (GameObject.Find("right tower").GetComponent<EnemyTower>().Fire(GameObject.Find("enemy chosen power").GetComponent<EnemyChosenPowerLVL>().energy))
            {
                Instantiate(myShot, transform.position, Quaternion.Euler(0, 0, 180));
            }
        }
        
    }
}