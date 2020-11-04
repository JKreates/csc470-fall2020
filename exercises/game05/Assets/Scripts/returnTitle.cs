using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class returnTitle : MonoBehaviour
{

	public Button retur;
    // Start is called before the first frame update
    void Start()
    {
        Button ret = retur.GetComponent<Button>();
       	ret.onClick.AddListener(taskcli11);
    }

    // Update is called once per frame
    void taskcli11()
    {
         SceneManager.LoadScene("SampleScene");
    }
}
