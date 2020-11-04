using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class exitAccusation : MonoBehaviour
{

	public Button ac;
    // Start is called before the first frame update
    void Start()
    {
        Button acu = ac.GetComponent<Button>();
        acu.onClick.AddListener(taskcli9);
    }

    // Update is called once per frame
    void taskcli9()
    {
        GameObject[] goArray = GameObject.FindGameObjectsWithTag ("Accuse");
 
        foreach(GameObject accuse in goArray)
        {
            accuse.SetActive (false);
        }
    }
}
