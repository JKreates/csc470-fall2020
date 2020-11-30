using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class ODoor : MonoBehaviour
{

	public GameObject bye1;
	public GameObject bye2;
	public GameObject bye3;
	public GameObject bye4;
	public GameObject bye5;
	public GameObject bye6;
	public GameObject bye7;
	public GameObject bye8;
	public GameObject bye9;
	public GameObject bye10;
	public GameObject bye11;
	public GameObject bye12;
	public GameObject bye13;
	public GameObject bye14;
	public GameObject bye15;
	public GameObject bye16;
	public GameObject bye17;

    // Start is called before the first frame update
    void Start()
    {
    	bye1 = GameObject.Find("Or1");
    	bye2 = GameObject.Find("Or2");
    	bye3 = GameObject.Find("Or3");
    	bye4 = GameObject.Find("Or4");
    	bye5 = GameObject.Find("Or5");
    	bye6 = GameObject.Find("Or6");
    	bye7 = GameObject.Find("Or7");
    	bye8 = GameObject.Find("Or8");
    	bye9 = GameObject.Find("Or9");
    	bye10 = GameObject.Find("Or10");
    	bye11 = GameObject.Find("Or11");
    	bye12 = GameObject.Find("Or12");
    	bye13 = GameObject.Find("Or13");
    	bye14 = GameObject.Find("Or14");
    	bye15 = GameObject.Find("Or15");
    	bye16 = GameObject.Find("Orange Door");
    	bye17 = GameObject.Find("Orange Door Unlock");
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
        	bye8.SetActive(false);
        	bye9.SetActive(false);
        	bye10.SetActive(false);
        	bye11.SetActive(false);
        	bye12.SetActive(false);
        	bye13.SetActive(false);
        	bye14.SetActive(false);
        	bye15.SetActive(false);
        	bye16.SetActive(false);
        	bye17.SetActive(false);
        }
    }
