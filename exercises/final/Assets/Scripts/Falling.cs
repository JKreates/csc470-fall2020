using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Falling : MonoBehaviour
{
	public Button fall;
    // Start is called before the first frame update
    void Start()
    {
        Button fa = fall.GetComponent<Button>();
        fa.onClick.AddListener(taskclick4);
    }

    // Update is called once per frame
    void taskclick4()
    {
        SceneManager.LoadScene("Game02");
    }
}
