using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class PlaneController : MonoBehaviour
{

	float spd = 40;
	float rotateSpd = 40;
	public CharacterController plane;

    // Start is called before the first frame update
    void Start()
    {
        plane = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    	float hAxis = Input.GetAxis("Horizontal");

    	transform.Rotate(0, hAxis * rotateSpd * Time.deltaTime, 0, Space.Self);
        transform.Translate(transform.forward * spd * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Barrier"))
        {
        	SceneManager.LoadScene("GameOver2");
		}
		if(other.gameObject.CompareTag("Win")){
			SceneManager.LoadScene("End");
		}
}
}
