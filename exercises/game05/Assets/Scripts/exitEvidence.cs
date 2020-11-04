using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class exitEvidence : MonoBehaviour
{

	public Button ev;
    // Start is called before the first frame update
    void Start()
    {
        Button evi = ev.GetComponent<Button>();
        evi.onClick.AddListener(taskcli8);
    }

    // Update is called once per frame
    void taskcli8()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Evidence");
 
        foreach(GameObject evide in goArray)
        {
            evide.SetActive (false);
        }
    }
}
