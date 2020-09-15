using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class destination : MonoBehaviour
{
    Rigidbody aster;
    float speed;
    public GameObject sun;

  //  asteroid = gameObject.Find("Asteroid");

    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sun");
        aster = GetComponent<Rigidbody>();
        speed = 500.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 towards = sun.transform.position - transform.position;
        towards = towards.normalized;
        transform.Translate(towards * Time.deltaTime * 10);
        // aster.velocity = transform.forward * speed;
    }
}
