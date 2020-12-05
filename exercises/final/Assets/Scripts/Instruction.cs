using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
	public Button instruct;
    // Start is called before the first frame update
    void Start()
    {
        Button ins = instruct.GetComponent<Button>();
        ins.onClick.AddListener(taskclick5);
    }

    // Update is called once per frame
    void taskclick5()
    {
        SceneManager.LoadScene("Instructions");
    }
}
