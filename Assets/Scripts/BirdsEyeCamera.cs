//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that controls a camera placed on player's head to give birds eye view.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsEyeCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 20, 0);

    }
}
