using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTesting : MonoBehaviour {

    public GameObject Camera;
    public GameObject Mirror;
    private Vector3 position;

	// Use this for initialization
	void Start () {
        
        while(true)
        {

        }

		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKeyDown("left"))
        {
            position = Camera.transform.position;
            position.x += 0.5f;
            Camera.transform.position = position;
            position = Mirror.transform.position;
            position.x += 0.5f;
            Mirror.transform.position = position;
        }
        if (Input.GetKeyDown("right"))
        {
            position = Camera.transform.position;
            position.x -= 0.5f;
            Camera.transform.position = position;
            position = Mirror.transform.position;
            position.x -= 0.5f;
            Mirror.transform.position = position;
        }
        if (Input.GetKeyDown("up"))
        {
            position = Camera.transform.position;
            position.z += 0.5f;
            Camera.transform.position = position;
            position = Mirror.transform.position;
            position.z += 0.5f;
            Mirror.transform.position = position;
        }
        if (Input.GetKeyDown("down"))
        {
            position = Camera.transform.position;
            position.z -= 0.5f;
            Camera.transform.position = position;
            position = Mirror.transform.position;
            position.z -= 0.5f;
            Mirror.transform.position = position;
        }


    }
}
