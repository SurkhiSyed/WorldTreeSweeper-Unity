//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that controls the Dark Goblins so that they chase the player and uses animations

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class M3MonsterMovement : MonoBehaviour
{
    

    public GameObject player;
    public bool isColliding;


    public GameObject Monster;
    public NavMeshAgent enemy;
    public Transform Player;
    public float timer;
    public float Runspeed;
    public float rotateSpeed;
    public string condition;
    
    // Start is called before the first frame update
    void Start()
    {
        condition = "Normal";
        Monster.GetComponent<Animation>().Play("M3WalkSlow");
        

    }

    // Update is called once per frame
    void Update()
    {
        float playerX = player.transform.position.x;
        float MonsterX = player.transform.position.x;

        float playerY = player.transform.position.y;
        float MonsterY = player.transform.position.y;
        
        
        enemy.SetDestination(Player.position);

        

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
