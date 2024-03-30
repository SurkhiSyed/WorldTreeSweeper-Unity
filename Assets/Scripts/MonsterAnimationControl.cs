//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that makes the monster attack the player if there is a collision and plays the punch animations

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimationControl : MonoBehaviour
{
    public GameObject Monster;
    public bool isColliding;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Monster.transform.position;
        if(isColliding == true)
        {
            Monster.GetComponent<Animation>().Play("Punch");
            
        }
        else if(isColliding == false)
        {
            Monster.GetComponent<Animation>().Play("M3WalkSlow");
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isColliding = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            isColliding = false;
        }

    }
}
