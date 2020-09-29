using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Button3 : MonoBehaviour
{

	public Button restartbutton;

    // Start is called before the first frame update
    void Start()
    {
        Button restart = restartbutton.GetComponent<Button>();
        restart.onClick.AddListener(TaskClick4);    
    }

    // Update is called once per frame
    void TaskClick4()
    {
        SceneManager.LoadScene("SampleScene");
    }
}