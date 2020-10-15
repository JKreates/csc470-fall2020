using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button2 : MonoBehaviour
{
	public Button giveup;
    // Start is called before the first frame update
    void Start()
    {
        Button give = giveup.GetComponent<Button>();
        give.onClick.AddListener(taskclick2);
    }

    // Update is called once per frame
    void taskclick2()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
