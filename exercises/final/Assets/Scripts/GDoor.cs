using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class GDoor : MonoBehaviour
{

	public GameObject bye1;
	public GameObject bye2;

    // Start is called before the first frame update
    void Start()
    {
    	bye1 = GameObject.Find("Green Door");
    	bye2 = GameObject.Find("Green Door Unlock");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        	bye1.SetActive(false);
        	bye2.SetActive(false);
        }
    }
