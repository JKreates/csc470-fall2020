using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button4 : MonoBehaviour
{

	public Button restart;
	public Button retur;
    // Start is called before the first frame update
    void Start()
    {
        Button reset = restart.GetComponent<Button>();
        reset.onClick.AddListener(taskclick5);

        Button ret = retur.GetComponent<Button>();
        ret.onClick.AddListener(taskclick6);
    }

    // Update is called once per frame
    void taskclick5()
    {
        SceneManager.LoadScene("Stage1");
    }

    void taskclick6()
    {
    	SceneManager.LoadScene("TitleScreen");
    }
}
