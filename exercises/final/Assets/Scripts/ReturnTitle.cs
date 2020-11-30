using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;


public class ReturnTitle : MonoBehaviour
{

	public Button bootin;
    // Start is called before the first frame update
    void Start()
    {
        Button boot = bootin.GetComponent<Button>();
        boot.onClick.AddListener(click2);
    }

    // Update is called once per frame
    void click2()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
