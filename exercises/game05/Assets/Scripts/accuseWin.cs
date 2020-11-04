using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class accuseWin : MonoBehaviour
{

	public Button win;
    // Start is called before the first frame update
    void Start()
    {
        Button winend = win.GetComponent<Button>();
       	winend.onClick.AddListener(taskcli10);
    }

    // Update is called once per frame
    void taskcli10()
    {
         SceneManager.LoadScene("GoodEndScene");
    }
}
