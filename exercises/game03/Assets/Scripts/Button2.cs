using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{

	public Button beginbutton;

    // Start is called before the first frame update
    void Start()
    {
        Button begin = beginbutton.GetComponent<Button>();
        begin.onClick.AddListener(TaskClick3);    
    }

    // Update is called once per frame
    void TaskClick3()
    {
        SceneManager.LoadScene("SampleScene");
    }
}