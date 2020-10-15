using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button3 : MonoBehaviour
{
	public Button go;
    // Start is called before the first frame update
    void Start()
    {
        Button letsgo = go.GetComponent<Button>();
        letsgo.onClick.AddListener(taskclick3);
    }

    // Update is called once per frame
    void taskclick3()
    {
        SceneManager.LoadScene("Stage1");
    }
}
