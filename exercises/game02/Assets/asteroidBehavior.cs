using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class asteroidBehavior : MonoBehaviour
{
    Rigidbody aster;
    float speed;

  //  asteroid = gameObject.Find("Asteroid");

    // Start is called before the first frame update
    void Start()
    {
        aster = GetComponent<Rigidbody>();
        speed = 500.0f;
    }

    // Update is called once per frame
    void Update()
    {
        aster.velocity = transform.forward * speed;
    }
}
