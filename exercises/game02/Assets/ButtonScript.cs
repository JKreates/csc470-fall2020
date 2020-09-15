using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    GameObject moon;
    public Button Button1;
    public Button Button2;
    // Start is called before the first frame update
    void Start()
    {
        Button but1 = Button1.GetComponent<Button>();
        moon = GameObject.Find("Moon");
        but1.onClick.AddListener(TaskOnClick);

        Button but2 = Button2.GetComponent<Button>();
        but2.onClick.AddListener(TaskClick2);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("End");

    }

    void TaskClick2()
    {
        SceneManager.LoadScene("SceneSun");
    }
}
