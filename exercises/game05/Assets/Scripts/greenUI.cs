using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class greenUI : MonoBehaviour
{

	public Button green;
    // Start is called before the first frame update
    void Start()
    {
        Button greenVis = green.GetComponent<Button>();
        greenVis.onClick.AddListener(taskcli4);
    }

    // Update is called once per frame
    void taskcli4()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Green UI");
 
        foreach(GameObject green1 in goArray)
        {
            green1.SetActive (false);
        }
    }
}
