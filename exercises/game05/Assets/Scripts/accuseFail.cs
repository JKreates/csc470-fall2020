using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class accuseFail : MonoBehaviour
{

	public Button bad;
    // Start is called before the first frame update
    void Start()
    {
        Button badend = bad.GetComponent<Button>();
       	badend.onClick.AddListener(taskcli9);
    }

    // Update is called once per frame
    void taskcli9()
    {
         SceneManager.LoadScene("BadEndScene");
    }
}
