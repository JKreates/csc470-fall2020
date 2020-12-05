using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Button3 : MonoBehaviour
{
	public Button splat;
    // Start is called before the first frame update
    void Start()
    {
        Button sp = splat.GetComponent<Button>();
        sp.onClick.AddListener(taskclick8);
    }

    // Update is called once per frame
    void taskclick8()
    {
        SceneManager.LoadScene("Game02");
    }
}
