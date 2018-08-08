using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {


    public GameObject movable;
    private Vector3 position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
   public void move()
    {
        position = movable.transform.position;
        position.y += 0.2f;
        movable.transform.position = position;
        print("HELLO!");

    }
}

