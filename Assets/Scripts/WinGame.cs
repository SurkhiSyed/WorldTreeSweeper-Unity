//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that controls the gate and its animations as the player reaches hs destination.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WinGame : MonoBehaviour
{
    public GameObject player;
    public bool isColliding;
    public GameObject door;
    public GameObject winningScreen;

    // Start is called before the first frame update
    void Start()
    {
        winningScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(467, 196, 297);
        if (isColliding == true)
        {
            door.GetComponent<Animation>().Play("Open");
            winningScreen.SetActive(true);
            Application.Quit();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isColliding = true;

        }
    }
}
