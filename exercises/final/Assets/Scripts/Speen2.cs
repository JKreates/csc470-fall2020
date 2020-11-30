using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speen2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(-60,-45,-60) * Time.deltaTime);
    }
}
