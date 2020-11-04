using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class whiteUI : MonoBehaviour
{

	public Button white;
    // Start is called before the first frame update
    void Start()
    {
        Button whiteVis = white.GetComponent<Button>();
        whiteVis.onClick.AddListener(taskcli7);
    }

    // Update is called once per frame
    void taskcli7()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("White UI");
 
        foreach(GameObject white1 in goArray)
        {
            white1.SetActive (false);
        }
    }
}
