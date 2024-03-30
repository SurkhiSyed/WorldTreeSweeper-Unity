//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that allows the player to control the character so that it moves and turns and uses animations

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharControl : MonoBehaviour
{
   
    public GameObject thePlayer;
    public GameObject monster;

    public bool isRunning;
    public float horizontalMove;
    public float Runspeed = 5;
    public float verticalMove;
    public float rotateSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, horizontalMove * rotateSpeed);

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            horizontalMove = Input.GetAxis("Horizontal");
            verticalMove = Input.GetAxis("Vertical");
            isRunning = true;
            if (Input.GetButton("Vertical"))
            {
                thePlayer.GetComponent<Animation>().Play("FinalRunning");
            }
            transform.Rotate(Vector3.up, horizontalMove * rotateSpeed);
            transform.Translate(Vector3.forward * Time.deltaTime * verticalMove* Runspeed);
        }
        else
        {
            thePlayer.GetComponent<Animation>().Play("StandingIdle");
            isRunning = false;
        }

        
    }

    
}
