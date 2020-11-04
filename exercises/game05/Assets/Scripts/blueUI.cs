using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class blueUI : MonoBehaviour
{

	public Button blue;
    // Start is called before the first frame update
    void Start()
    {
        Button blueVis = blue.GetComponent<Button>();
        blueVis.onClick.AddListener(taskcli3);
    }

    // Update is called once per frame
    void taskcli3()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Blue UI");
 
        foreach(GameObject blue1 in goArray)
        {
            blue1.SetActive (false);
        }
    }
}
