using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;

    public int NumberOfHazzards;
    // public int HazzardsLeft = 1;
    public int BestScore;
    public int NumberOfSwitches;
    public int NumberOfStars;
    public GameObject[] Stars;
    public GameObject ScoreUi;

    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
           // Debug.Log("I was here");
            //ScoreUi.GetComponent<Renderer>().enabled = false;   
            ScoreUi.active = false;
            NumberOfHazzards = 5;
            BestScore = 9;

            //Stars = new GameObject[4];
            for (int i = 0; i < 4; i++)
            {
                Stars[i].active = false;
            }
            
        }
        else if(instance != this){
            Destroy(gameObject);

        }


    }
	
	// Update is called once per frame
	void Update () {
        if (NumberOfHazzards == 0) {
            //ScoreUi.active = true;
            float score = NumberOfSwitches;
            if (score <= BestScore + .25f * BestScore)
            {
                NumberOfStars = 4;
                
            }
            else if (score <= BestScore + .5f * BestScore)
            {
                NumberOfStars = 3;
            }
            else if (score <= BestScore + .75f * BestScore)
            {
                NumberOfStars = 2;
            }
            else {
                NumberOfStars = 1;
            }
            ScoreUi.active = true;
            Debug.Log("no of stars" + NumberOfStars);
            for (int i = 0; i < NumberOfStars ; i++)
            {
                Stars[i].active = true;
                Debug.Log(i + " hagar w yasmeen naymin");
            }


        }
		
	}
}
