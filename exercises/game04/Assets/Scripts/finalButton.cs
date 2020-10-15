using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class finalButton : MonoBehaviour
{

	public Button mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        Button ending = mainmenu.GetComponent<Button>();
        ending.onClick.AddListener(taskclickfinal);
    }

    // Update is called once per frame
    void taskclickfinal()
    {
    	SceneManager.LoadScene("TitleScreen");
    }
}
