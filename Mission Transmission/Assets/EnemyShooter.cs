using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public GameObject myShot;
    public int ChosenPower;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
        
    {
        // Get the rigidbody component
        //Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        float positon = Random.Range(-10.46f, 6.24f);
        transform.position = new Vector3(23.9f, positon);
        ChosenPower = (int)Random.Range(1.0f, 5.0f);
        if (GameObject.Find("right tower").GetComponent<EnemyTower>().Fire(ChosenPower) == true)
        {
            Instantiate(myShot, transform.position, Quaternion.Euler(0, 0, 180));
        }
        
    }
}