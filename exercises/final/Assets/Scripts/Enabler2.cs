using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Enabler2 : MonoBehaviour
{

	public GameObject plat1;
	public GameObject plat2;
	public GameObject plat3;

    // Start is called before the first frame update
    void Start()
    {
    	plat1 = GameObject.Find("Platf2");
    	plat2 = GameObject.Find("Platf3");
    	plat3 = GameObject.Find("Platf4");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        	plat1.SetActive(true);
        	plat2.SetActive(true);
        	plat3.SetActive(true);
        }
    }
