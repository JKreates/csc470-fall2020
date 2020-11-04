using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class redUI : MonoBehaviour
{

	public Button red;
    // Start is called before the first frame update
    void Start()
    {
        Button redVis = red.GetComponent<Button>();
        redVis.onClick.AddListener(taskcli);
    }

    // Update is called once per frame
    void taskcli()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Red UI");
 
        foreach(GameObject red1 in goArray)
        {
            red1.SetActive (false);
        }
    }
}
