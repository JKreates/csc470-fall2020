using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
	public Button next;
    // Start is called before the first frame update
    void Start()
    {
        Button nex = next.GetComponent<Button>();
        nex.onClick.AddListener(taskclick3);
    }

    // Update is called once per frame
    void taskclick3()
    {
        SceneManager.LoadScene("Game01");
    }
}
