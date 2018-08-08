using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
   public GameObject[] HomeButtons;
    public GameObject[] LevelButtons;

    public GameObject Head;
    private int CurrentScreen = 0;
    private int PreviousScreen;
    private int ObjectIndex = 0;
    private Vector3 pos;

    private Vector3 defaultScale;
    private Vector3 SelectedScale;
    //public Animation ForwardAnimation;
    //public Animation BackwardAnimation;
    
    private Vector3 CamPosition;
    // Use this for initialization
    void Start () {
        defaultScale.x = defaultScale.y = defaultScale.z = 16;
        SelectedScale.x = SelectedScale.y = SelectedScale.z = 20;
    }
    void Toggle () {
        ObjectIndex ^= 1;
        
    }

    // Update is called once per frame
    void Update () {

        if (CurrentScreen == 0) {
            if (Input.GetAxis("Horizontal") == 1 ) //right -1//lef VErtical 1//up -1//down 
            {
                ObjectIndex = 1;
                HomeButtons[0].transform.localScale = defaultScale;
                //Toggle();  
                print("ANALOG");
                HomeButtons[1].transform.localScale = SelectedScale;
                
            }
            if( Input.GetAxis("Horizontal") == -1)
            {
                ObjectIndex = 0;
                HomeButtons[1].transform.localScale = defaultScale;
                //Toggle();  
                print("ANALOG");
                HomeButtons[0].transform.localScale = SelectedScale;
            }
            if (anyKeyInput ()) {
                PreviousScreen = 0;
                if (ObjectIndex == 0)
                    CurrentScreen++;
                MoveThru();
            }

        } else {
            if (Input.GetAxis("Vertical") == 1 ) //right -1//lef VErtical 1//up -1//down 
            {
                ObjectIndex = 1;
                LevelButtons[0].transform.localScale = defaultScale;
                 print("ANALOG");
                LevelButtons[1].transform.localScale = SelectedScale;
            }
            else if(Input.GetAxis("Vertical") == -1)
            {
                ObjectIndex = 0;
                LevelButtons[1].transform.localScale = defaultScale;
                 print("ANALOG");
                LevelButtons[0].transform.localScale = SelectedScale;
            }
            if (anyKeyInput ()) {
                if (ObjectIndex == 0) { // level 1 switch to scene 2
                    PreviousScreen = 1;
                    CurrentScreen = 2;
                    SceneManager.LoadScene(1);
                } else {
                    PreviousScreen = 1;
                    CurrentScreen = 0 ;
                }
                MoveThru();
            }
        }

    }

    bool anyKeyInput () {
        //print("KEY");
        foreach (KeyCode vkey in System.Enum.GetValues (typeof (KeyCode))) {
            if (Input.GetKeyUp(vkey)) {
                print("KEY");
                return true;
            }
        }
        return false;

    }

    void MoveThru () {
        ObjectIndex = 0;
        if (CurrentScreen == 0 && PreviousScreen == 1)
            MoveBackward();
         
        if (CurrentScreen == 1 && PreviousScreen == 0)
            MoveForward();
        //if (CurrentScreen == 2 && PreviousScreen == 1)
       
       
    }

    void MoveForward()
    {
        print("FORWARD");
        pos = Head.transform.position;
        pos.x=450;
        Head.transform.position=pos;
    }
    void MoveBackward()
    {
        print("BACKWARD");

        pos = Head.transform.position;
        pos.x= -540;
        Head.transform.position=pos;
    }
}