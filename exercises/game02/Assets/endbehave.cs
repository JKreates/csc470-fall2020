using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endbehave : MonoBehaviour
{
    public float Countdown;
    // Start is called before the first frame update
    void Start()
    {
        Countdown = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Countdown > 0)
        {
            Countdown = Countdown - Time.deltaTime;
        }

        else
        {
            transform.Rotate(Vector3.down, 45);
            Countdown = 2.0f;
        }
    }
}
