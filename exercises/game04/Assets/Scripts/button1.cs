using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{

	public Button begin;
    // Start is called before the first frame update
    void Start()
    {
        Button beginning = begin.GetComponent<Button>();
        beginning.onClick.AddListener(taskclick1);
    }

    // Update is called once per frame
    void taskclick1()
    {
         SceneManager.LoadScene("Transition");
    }
}
