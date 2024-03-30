//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that makes the player lose health every time it collides with the monster or other obstacles

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideMosnter : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 4;
    private float _currentHealth = 3.75f;
    [SerializeField] private HealthBar _healthBar;

    public bool isColliding = false;
    public GameObject monster;
    public GameObject monster2;
    public GameObject monster3;
    public GameObject monster4;
    public GameObject monster5;
    public GameObject monster6;
    public GameObject monster7;
    public GameObject monster8;
    public GameObject monster9;
    public GameObject monster10;


    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //_healthBar.UpdateHealthBar(_maxHealth, _currentHealth);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        if (isColliding == true)
        {
            _currentHealth -= 0.25f;
            _healthBar.UpdateHealthBar(_maxHealth, _currentHealth);
            isColliding = false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
         
        if (other.gameObject == monster || monster2 || monster3 || monster4 || monster5 || monster6 || monster7 || monster9 || monster10)
        { 
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == monster || monster2 || monster3 || monster4 || monster5 || monster6 || monster7 || monster9 || monster10)
        {
            isColliding = false;
        }
    }
}

