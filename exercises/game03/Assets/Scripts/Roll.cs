using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class Roll : MonoBehaviour
{
	public float spd;
	private Rigidbody rb;
	private float moveX, moveY;
	public GameObject losetext;
	public GameObject wintext;


    // Start is called before the first frame update
    void Start()
    {
    	spd = 5;
    	rb = GetComponent<Rigidbody>();
    	losetext = GameObject.Find("Gameover");
    	wintext = GameObject.Find("Winner");
    	losetext.SetActive(false);
    	wintext.SetActive(false);
      	//float hori = Input.GetAxisRaw("Horizontal");
       // float vert = Input.GetAxisRaw("Vertical");

        //gameObject.transform.position = new Vector3(transform.position.x + (hori * spd), 0,  transform.position.z + (vert * spd));
    }

    // Update is called once per frame
    void Update()
    {
    	moveX = Input.GetAxis("Horizontal") * spd;
    	moveY = Input.GetAxis("Vertical") * spd;
       // float hori = Input.GetAxisRaw("Horizontal");
       // float vert = Input.GetAxisRaw("Vertical");

       // gameObject.transform.position = new Vector3(transform.position.x + (hori * spd), 0,  transform.position.z + (vert * spd));

    }
    //if ball hits dead tag, then delete ball
    void FixedUpdate(){
    	rb.velocity = new Vector3(moveX, rb.velocity.y, moveY);

    }
    private void Collision(Collider other)
    {
        if(other.gameObject.CompareTag("Dead"))
        {
            losetext.SetActive(true);
            SceneManager.LoadScene("SampleScene");

		}
        if(other.gameObject.CompareTag("Smith"))
        {
        	Destroy(gameObject);
        	wintext.SetActive(true);
        }

    }
}
