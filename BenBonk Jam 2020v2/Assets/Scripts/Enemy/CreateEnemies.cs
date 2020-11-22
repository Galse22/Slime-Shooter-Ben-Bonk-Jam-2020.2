using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour
{

    public GameObject _enemy;

    public float baseTime;
    public float currentTime;
    public float minTime;
    public float subtractValueTime;

    int rand;

    public GameObject[] GOsPlaces;

    public int rightInt;

    void Start()
    {
        currentTime = baseTime;
        StartCoroutine (SpawnEnemy());
    }

    
    IEnumerator SpawnEnemy ()
    {
        rand = Random.Range(0, GOsPlaces.Length);
        GameObject enemy = Instantiate (_enemy, GOsPlaces[rand].transform.position, GOsPlaces[rand].transform.rotation);
        if(rand > rightInt)
        {
            Transform transform = enemy.GetComponent<Transform>();
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
        if(currentTime - subtractValueTime > minTime)
        {
            currentTime = currentTime - subtractValueTime;
        }
        else
        {
            currentTime = minTime;
        }
        yield return new WaitForSeconds (currentTime);
        StartCoroutine (SpawnEnemy());
    }
}
