using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class exitEvidence1 : MonoBehaviour
{

	public Button ev1;
    // Start is called before the first frame update
    void Start()
    {
        Button evi1 = ev1.GetComponent<Button>();
        evi1.onClick.AddListener(taskcli12);
    }

    // Update is called once per frame
    void taskcli12()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Exit1");
 
        foreach(GameObject evide in goArray)
        {
            evide.SetActive (false);
        }
    }
}
