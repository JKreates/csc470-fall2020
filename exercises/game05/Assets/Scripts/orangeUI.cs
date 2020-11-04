using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class orangeUI : MonoBehaviour
{

	public Button orange;
    // Start is called before the first frame update
    void Start()
    {
        Button orangeVis = orange.GetComponent<Button>();
        orangeVis.onClick.AddListener(taskcli5);
    }

    // Update is called once per frame
    void taskcli5()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Orange UI");
 
        foreach(GameObject orange1 in goArray)
        {
            orange1.SetActive (false);
        }
    }
}
