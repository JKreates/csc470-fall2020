using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject spawn;

	int gridWidth = 30;
	int gridHeight = 200;

	float space = 0.6f;
	float distancing = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < gridWidth; x++){
        	for (int y = 0; y < gridHeight; y++){
        		Vector3 pos = new Vector3(x * (space + distancing), 140, y * (space + distancing));
        		GameObject obje = Instantiate(spawn, pos, Quaternion.identity);
        		spawn.transform.localScale = new Vector3(space, space, space);
        		cellscript script = obje.GetComponent<cellscript>();
        	}
        }
    }// Platform facing forward and goal is to roll ball to the end without hitting the dead spawns?

    // Update is called once per frame
    void Update()
    {
        
    }
}
