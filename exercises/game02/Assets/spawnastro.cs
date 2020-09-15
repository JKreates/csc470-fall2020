using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Permissions;
using System.Threading;
using UnityEngine;

public class spawnastro : MonoBehaviour
{
    public GameObject astroPrefab;
    GameObject astron;

    // Start is called before the first frame update
    void Start()
    {
        astron = GameObject.Find("Astronaut");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 locate = new Vector3(astron.transform.position.x + UnityEngine.Random.Range(-10, 10), astron.transform.position.y + 10, astron.transform.position.z + UnityEngine.Random.Range(-10,10));
        Instantiate(astroPrefab, locate, Quaternion.identity);
    }

    public void SpawnAstronauts()
    {

    }
}
