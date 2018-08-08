using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMovement : MonoBehaviour
{

    public GameObject Player;
    private Vector3 position;
    public GameObject GameManager;

    private bool YinYang = false; // false if Yin and true if Yang

    public GameObject Cam;

    public GameObject WhiteSphere;
    public GameObject BlackSphere;
    private GameManager G;
    private float thrust = 0.50f;

    bool isFlipped ;
    float direction = 1;
    // Use this for initialization
    void Start()
    {
         G = GameManager.GetComponent<GameManager>();
        isFlipped = false; // yin
        direction = 1;
       // Vector3 IntialPosition = new Vector3(2.2f,0.23f,-3.36f);
        //this.transform.position = IntialPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        G = GameManager.GetComponent<GameManager>();

        //Debug.Log("Update");

        position = Player.transform.position;
         //if (Input.GetAxis("Vertical") == 1)
        if(Input.GetKey("up"))
        {
            Vector3 temp = Vector3.Scale(Cam.transform.TransformDirection(Vector3.forward),new Vector3(0.03f,0.03f,0.03f));
            temp.y = 0;
            position += temp;

            //rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
        
        //if (Input.GetAxis("Vertical") == -1)
        if(Input.GetKey("down"))
        {
            Vector3 temp = Vector3.Scale(Cam.transform.TransformDirection(Vector3.back), new  Vector3(0.03f,0.03f,0.03f));
            temp.y = 0;
            position += temp;
            //rb.AddForce(0, -1 * thrust,0, ForceMode.Impulse);     
        }
//if (Input.GetAxis("Horizontal") == 1)
        if(Input.GetKey("right"))
        {
            Vector3 temp = Vector3.Scale(Cam.transform.TransformDirection(Vector3.right), new  Vector3(0.03f,0.03f,0.03f));
            temp.y = 0;
            position += temp;
        }
        //if (Input.GetAxis("Horizontal")==-1)
        if(Input.GetKey("left"))
        {
            Vector3 temp = Vector3.Scale(Cam.transform.TransformDirection(Vector3.left), new  Vector3(0.03f,0.03f,0.03f)); temp.y = 0;
            position += temp;
        }
        Player.transform.position = position;
        int i = 0;
        //foreach (KeyCode vkey in System.Enum.GetValues(typeof(KeyCode)))
        {
           
            if (Input.GetKeyUp("space"))
            {
                //i++;
                //if (i == 2)
                {
                  //  i=0;
                    G.NumberOfSwitches++;
                    isFlipped = !isFlipped;
                    //direction = -1.0f * direction;


                    if (YinYang == false)
                    {
                        //Yin
                        BlackSphere.SetActive(true);

                        position = Player.transform.position;
                        position.y -= 0.6f;
                        Player.transform.position = position;

                        transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);

                    }
                    else
                    {
                        //Yang
                        WhiteSphere.SetActive(true);

                        position = Player.transform.position;
                        position.y += 0.6f;
                        Player.transform.position = position;

                        transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);

                    }
                    YinYang = !YinYang;

                    print("keeeyyy!");

                    BlackSphere.SetActive(false);
                    WhiteSphere.SetActive(false);

                }
            }
        }
       

    }


    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.0f);
    }

}