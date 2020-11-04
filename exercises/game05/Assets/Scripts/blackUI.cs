using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class blackUI : MonoBehaviour
{

	public Button black;
    // Start is called before the first frame update
    void Start()
    {
        Button blackVis = black.GetComponent<Button>();
        blackVis.onClick.AddListener(taskcli2);
    }

    // Update is called once per frame
    void taskcli2()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Black UI");
 
        foreach(GameObject black1 in goArray)
        {
            black1.SetActive (false);
        }
    }
}
