﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class HD2 : MonoBehaviour
{

	public GameObject dest;
    // Start is called before the first frame update
    void Start()
    {
    	dest = GameObject.Find("Hidden Destructible 2");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        	dest.SetActive(false);
        }
    }