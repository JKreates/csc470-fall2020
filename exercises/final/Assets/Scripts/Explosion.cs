using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Explosion : MonoBehaviour
{

	float speed = 80;
	public GameObject explode;

    // Start is called before the first frame update
    void Start()
    {
        explode = gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * Time.deltaTime);
	}
}