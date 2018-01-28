using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {
    public GameObject myShot;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the rigidbody component
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        float positon = Random.Range(-10.46f, 6.24f);
        transform.position = new Vector3(23.9f, positon);
        int power = (int)Random.Range(1.0f, 6f);
        if (GameObject.Find("right tower").GetComponent<EnemyTower>().Fire(power))
        {
            Instantiate(myShot, transform.position, Quaternion.Euler(0, 0, 180));
            ((EnemyWave)myShot.GetComponent<EnemyWave>()).power = power;
        }
    }
}