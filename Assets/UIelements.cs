using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIelements : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void unHover()
    {

        gameObject.transform.localScale = new Vector3(1,1,1);
    }
    public void hover()
    {
        gameObject.transform.localScale = new Vector3(2, 2, 2);
    }
}
