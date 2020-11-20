using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour
{

    public GameObject _enemy;

    public float time;

    public int score;

    int rand;

    public GameObject[] GOs1;
    public GameObject[] GOs2;
    public GameObject[] GOs3;
    public GameObject[] GOs4;

    void Start()
    {
        time = 1.5f;
        StartCoroutine (SpawnEnemy());
    }

    
    IEnumerator SpawnEnemy ()
    {
        if(score < 250)
        {
            rand = Random.Range(0, GOs1.Length);
            Instantiate (_enemy, GOs1[rand].transform.position, Quaternion.identity);
        }
        else if(score < 500)
        {
            rand = Random.Range(0, GOs2.Length);
            Instantiate (_enemy, GOs2[rand].transform.position, Quaternion.identity); 
        }
        else if(score < 750)
        {
            rand = Random.Range(0, GOs3.Length);
            Instantiate (_enemy, GOs3[rand].transform.position, Quaternion.identity); 
        }
        else if(score < 1000)
        {
            rand = Random.Range(0, GOs4.Length);
            Instantiate (_enemy, GOs4[rand].transform.position, Quaternion.identity); 
        }
        yield return new WaitForSeconds (time);
        StartCoroutine (SpawnEnemy());
    }
}
