using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform [] enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public Text waveCountdownText;
    private int waveIndex = 0;

    public float timeBetweenEnemies;

    // Update is called once per frame
    void Update()
    {

        if (countdown <= 0f)
        {
            StartCoroutine( SpawnWave());
            countdown = timeBetweenWaves;

            if(  waveIndex % 5 == 0)
            {
                timeBetweenWaves += 5;
                Debug.Log(timeBetweenWaves.ToString());
            }

        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00}", countdown );

    }


    IEnumerator SpawnWave()
    {
        //numOfEnemies = waves[waveNumber].count;
        //numOfEnemies = numOfEnemies * numOfEnemies +1;

        for (int i = 0; i < waveIndex; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemies);

        }

        waveIndex++;

    }



    void spawnEnemy()
    {
        int i = Random.Range(0, 3);
        Instantiate(enemyPrefab[i],spawnPoint.position, spawnPoint.rotation);

    }

}
