using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private int angle = 0;
    public GameObject GameManager;
    public GameObject WhiteHazzards;
    public GameObject BlackHazzards;
    public GameObject YinCoins;
    public GameObject YangCoins;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        angle += 1;
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
        GameManager G = GameManager.GetComponent<GameManager>();
        Debug.Log(G.NumberOfHazzards + "yaaaaaa!!!");
        G.NumberOfHazzards -= 1;
        string text;
        Debug.Log(G.NumberOfHazzards + "no of hazzards left");
        if (this.transform.parent.name == "YinCoins")
        {
            Debug.Log(this.transform.parent.ToString());
            Debug.Log("Yin");
            text = WhiteHazzards.GetComponent<TextMesh>().text;
            Debug.Log(text);
            int num;
            int.TryParse(text, out num);
            num--;
            string converted = num.ToString();
            TextMesh t = (TextMesh)WhiteHazzards.GetComponent<TextMesh>();
            t.text = converted;
        }
        else 
        {
            Debug.Log("Yang");
            text = BlackHazzards.GetComponent<TextMesh>().text;
            Debug.Log(text);
            int num;
            int.TryParse(text, out num);
            num--;
            string converted = num.ToString();
            TextMesh t = (TextMesh)BlackHazzards.GetComponent<TextMesh>();
            t.text = converted;
        }
        


    }
}
