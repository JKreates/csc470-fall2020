using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
 
 	public GameObject ball;
	private Vector3 posit;
    // Start is called before the first frame update
    void Start()
    {
        posit = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + posit;
    }
}
