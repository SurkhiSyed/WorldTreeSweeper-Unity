//Syed Kaab Surkhi
//Mr A. Mayer
//June 20, 2023
//Program that spawns the Dark Golins all over the map based on range specified

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMananager : MonoBehaviour
{
    public GameObject Monster;
    public int xPos;
    public int ZPos;
    public int enemyCount;
    private float spawnInterval = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount <= 10)
        {
            xPos = Random.Range(100, 900);
            ZPos = Random.Range(100, 900);
            Instantiate(Monster, new Vector3(xPos, 250, ZPos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemyCount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
