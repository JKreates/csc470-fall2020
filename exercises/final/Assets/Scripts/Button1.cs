using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
	public Button start;
    // Start is called before the first frame update
    void Start()
    {
        Button st = start.GetComponent<Button>();
        st.onClick.AddListener(taskclick);
    }

    // Update is called once per frame
    void taskclick()
    {
        SceneManager.LoadScene("TransitionScene");
    }
}
