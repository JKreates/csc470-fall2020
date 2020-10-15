using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
	float movingSpeed = 400;
	float rotatingSpeed = 150;
	float velocityY = 0;
	float jumping = 3f;
	float gravMod = 0.2f;
	bool grouded = false;

	public CharacterController chara;

	
	// Start is called before the first frame update
	void Start()
	{
		chara = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update()
	{
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		transform.Rotate(0, hAxis * rotatingSpeed * Time.deltaTime, 0);


		if (!chara.isGrounded){
			velocityY = velocityY + Physics.gravity.y * gravMod * Time.deltaTime;

			if (Input.GetKeyUp(KeyCode.Space) && velocityY > 0) {
				velocityY = 0;
			}
		} else {
			if (!grouded) {

				velocityY = 0;
			}

			if (Input.GetKeyDown(KeyCode.Space)) {
				velocityY = jumping;
			}
		}

		Vector3 totalMove = transform.forward * vAxis * movingSpeed * Time.deltaTime;

		totalMove.y = velocityY;

		chara.Move(totalMove);
		
		grouded = chara.isGrounded;

		if (velocityY < -3) {
			SceneManager.LoadScene("GameOver");
		}
		}

		private void OnTriggerEnter(Collider other)
    	{
			if(other.gameObject.CompareTag("Win")){
				SceneManager.LoadScene("FinalTransition");
		}
}
}