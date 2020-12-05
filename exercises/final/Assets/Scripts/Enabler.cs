using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Enabler : MonoBehaviour
{

	public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
    	platform = GameObject.Find("Platf1");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        	platform.GetComponent<Renderer>().enabled = true;
            platform.GetComponent<BoxCollider>().enabled = true;
        }
    }
