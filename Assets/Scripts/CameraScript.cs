//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Script that controls a camera to follow the player at all times and move as the mouse moves left/right

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    public int rotateSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,2, -2);
        if(Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0,-rotateSpeed*Time.deltaTime, 0);
        }
        if(Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }
}
