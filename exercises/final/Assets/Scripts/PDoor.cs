using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class PDoor : MonoBehaviour
{

	public GameObject bye1;
	public GameObject bye2;
	public GameObject bye3;
	public GameObject bye4;
	public GameObject bye5;
	public GameObject bye6;
	public GameObject bye7;

    // Start is called before the first frame update
    void Start()
    {
    	bye1 = GameObject.Find("Pink Door1");
    	bye2 = GameObject.Find("Pink Door2");
    	bye3 = GameObject.Find("Pink Door3");
    	bye4 = GameObject.Find("Pink Door4");
    	bye5 = GameObject.Find("Pink Door5");
    	bye6 = GameObject.Find("Pink Door6");
    	bye7 = GameObject.Find("Pink Door Unlock");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        	bye1.SetActive(false);
        	bye2.SetActive(false);
        	bye3.SetActive(false);
        	bye4.SetActive(false);
        	bye5.SetActive(false);
        	bye6.SetActive(false);
        	bye7.SetActive(false);
        }
    }
