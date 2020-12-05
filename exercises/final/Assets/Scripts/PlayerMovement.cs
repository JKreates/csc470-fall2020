using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    float speed = 45;
    float velocity = 0;
    float jump = 0.55f;
    float grav = 0.3f;
    bool ground = false;

    public TextMeshProUGUI counter;
    private int count;
    public CharacterController play;
    public AudioClip get;
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        play = gameObject.GetComponent<CharacterController>();
        count = 3;
        SetCountText();
        audio = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        if (!play.isGrounded){
            velocity = velocity + Physics.gravity.y * grav * Time.deltaTime;

            if (Input.GetKeyUp(KeyCode.Space) && velocity > 0) {
                velocity = 0;
            }
        } else {
            if (!ground) {

                velocity = 0;
            }

            if (Input.GetKeyDown(KeyCode.Space)) {
                velocity = jump;
            }
        }

        Vector3 moove = transform.forward * vAxis * speed * Time.deltaTime;

        moove.y = velocity;

        play.Move(moove);
        
        ground = play.isGrounded;

    }

    void SetCountText()
    {
        counter.text = "Lives: " + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Life")){
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            Debug.Log("You got a life");
            audio.PlayOneShot(get);
        }
        if(other.gameObject.CompareTag("Death")){
            play.enabled = false;
            count -= 1;
            SetCountText();
            play.transform.position = new Vector3(18, 13, 4);
            play.enabled = true;
        }
        if(other.gameObject.CompareTag("Death2")){
            play.enabled = false;
            count -= 1;
            SetCountText();
            play.transform.position = new Vector3(852, 199, 4);
            play.enabled = true;
        }
        if(other.gameObject.CompareTag("Win")){
            SceneManager.LoadScene("Transition2");
        }
        if(other.gameObject.CompareTag("Death3")){
            play.enabled = false;
            count -= 1;
            SetCountText();
            play.transform.position = new Vector3(2243, 16, 4);
            play.enabled = true;
        }
        if(count == 0){
            SceneManager.LoadScene("GameOver");
        }
    }   
}