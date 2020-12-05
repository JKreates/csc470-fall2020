using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Splat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Death")){
            SceneManager.LoadScene("SplatDeath");
        }
    }
}