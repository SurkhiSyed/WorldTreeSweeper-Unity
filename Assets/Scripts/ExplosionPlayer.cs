//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that causes an explosion animation to play when the player steps on an explosive tile.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPlayer : MonoBehaviour
{
    public GameObject playerCollide;
    public GameObject player;
    public ParticleSystem explosion;
    public bool isColliding;

    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding == true)
        {
            //explosion.transform.position = gameObject.transform.position + new Vector3(0, 1, 0);
            ParticleSystem instantiatedEffect = Instantiate(explosion, transform.position, Quaternion.identity);
            explosion.Play();
            Destroy(player);
            Application.Quit();
            
            isColliding = false;
        }
        if(isColliding == false)
        {
            explosion.Stop();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerCollide)
        {
            isColliding = true;
        }
    }
    
}
