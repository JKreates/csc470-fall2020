using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Byebye : MonoBehaviour
{
    private Rigidbody rb;
    GameObject sun;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sun");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sun"))
        {
            Destroy(sun);
        }
    }
}
