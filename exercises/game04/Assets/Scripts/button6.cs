using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class button6 : MonoBehaviour
{

	public Button tofinal;

    // Start is called before the first frame update
    void Start()
    {
        Button fin = tofinal.GetComponent<Button>();
        fin.onClick.AddListener(taskclickfinal);

    // Update is called once per frame

    void taskclickfinal()
    {
    	SceneManager.LoadScene("FinalStage");
    }
}
}
