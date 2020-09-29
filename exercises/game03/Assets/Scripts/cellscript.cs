using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellscript : MonoBehaviour
{
	public bool _life = false;
	public Color colorLive;
	public Color colorDead;
	Renderer rending;
	public float countdown;

	public bool Living
	{

		get
		{
			return this._life;
		}

		set
		{
			this._life = value;
			
			if (this._life){
				rending.material.color = colorLive;
				gameObject.tag = "Live";
			}
			
			else{
				rending.material.color = colorDead;
				gameObject.tag = "Dead";
			}
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        rending = gameObject.GetComponent<Renderer>();
   		this.Living = Random.value < 0.7f;
   		countdown = 4.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            countdown = countdown - Time.deltaTime;
        }
        else{
        	rending = gameObject.GetComponent<Renderer>();
   			this.Living = Random.value < 0.5f;
   			countdown = 4.0f;
        }
    }
}
