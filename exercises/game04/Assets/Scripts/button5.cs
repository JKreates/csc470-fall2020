using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button5 : MonoBehaviour
{

	public Button restart;
	public Button retur;
    // Start is called before the first frame update
    void Start()
    {
        Button reset = restart.GetComponent<Button>();
        reset.onClick.AddListener(taskclick7);

        Button ret = retur.GetComponent<Button>();
        ret.onClick.AddListener(taskclick6);
    }

    // Update is called once per frame
    void taskclick7()
    {
        SceneManager.LoadScene("FinalStage");
    }

    void taskclick6()
    {
    	SceneManager.LoadScene("TitleScreen");
    }
}
