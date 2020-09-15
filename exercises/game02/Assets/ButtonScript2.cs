using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class ButtonScript2 : MonoBehaviour
{
    public Button Button2;
    // Start is called before the first frame update
    void Start()
    {
        Button but2 = Button2.GetComponent<Button>();
        but2.onClick.AddListener(Update);
    }

    // Update is called once per frame
    void Update()
    {
      //  SceneManager.LoadScene("End");
    }
}
