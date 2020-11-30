using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class AutoMovement : MonoBehaviour
{

	float speed = 80;
	public CharacterController skate;

    // Start is called before the first frame update
    void Start()
    {
        skate = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * Time.deltaTime);
    
        if(Input.GetKey(KeyCode.S)){
            transform.position += transform.right * -speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W)){
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Death"))
        {

            SceneManager.LoadScene("GameOver2");

        }

        if(other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene("TransitionFinal");
        }

    }
}
