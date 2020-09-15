using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class rotateMoon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            transform.Rotate(new Vector3(1800, 0, 1800) * Time.deltaTime);
        }
    }
}
