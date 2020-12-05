using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class SkateOut : MonoBehaviour
{
	public Button explode;
    // Start is called before the first frame update
    void Start()
    {
        Button ex = explode.GetComponent<Button>();
        ex.onClick.AddListener(taskclick5);
    }

    // Update is called once per frame
    void taskclick5()
    {
        SceneManager.LoadScene("Game03");
    }
}
