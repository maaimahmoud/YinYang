using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    public Vector3 defaultScale;
    public Vector3 selectedScale;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public string getName()
    {
        return "Play";

    }
    public void Select()
    {

        gameObject.transform.localScale = selectedScale;
    }
    public void unSelect()
    {
        gameObject.transform.localScale = selectedScale;
    }
}
