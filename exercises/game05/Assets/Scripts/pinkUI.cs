using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class pinkUI : MonoBehaviour
{

	public Button pink;
    // Start is called before the first frame update
    void Start()
    {
        Button pinkVis = pink.GetComponent<Button>();
        pinkVis.onClick.AddListener(taskcli6);
    }

    // Update is called once per frame
    void taskcli6()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Pink UI");
 
        foreach(GameObject pink1 in goArray)
        {
            pink1.SetActive (false);
        }
    }
}
