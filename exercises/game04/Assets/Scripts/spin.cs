using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(15,0,45) * Time.deltaTime);
    }
}
