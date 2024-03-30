//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that reduces the players health on every collision it faces

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField] private Image _healthbarSprite;
    public GameObject player;
    private Camera _cam;

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {

        _healthbarSprite.fillAmount = currentHealth / maxHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,2.5f,0);
        if(_healthbarSprite.fillAmount == 0)
        {
            Destroy(player);
            Application.Quit();
        }
        transform.rotation = Quaternion.LookRotation(transform.position - _cam.transform.position);
    }
}
