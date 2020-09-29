using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   
	public Button startbutton;
	public Button instructbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    	Button start = startbutton.GetComponent<Button>();
        start.onClick.AddListener(TaskOnClick);

        Button instruct = instructbutton.GetComponent<Button>();
        instruct.onClick.AddListener(TaskClick2);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene");

    }

    void TaskClick2()
    {
        SceneManager.LoadScene("InstructionScene");
    }
}
