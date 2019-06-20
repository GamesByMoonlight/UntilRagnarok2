using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public float timeBetweenWaves = 5f;
    private float countdown = 3f;

    private int waveIndex = 0;

    public Transform spawnPoint;

    public Text waveCountdownText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

        waveCountdownText.text = Mathf.Round( countdown).ToString();




    }


    IEnumerator SpawnWave()
    {
        //numOfEnemies = waves[waveNumber].count;
        //numOfEnemies = numOfEnemies * numOfEnemies +1;

        for (int i = 0; i < waveIndex; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.3f);

        }

        waveIndex++;

    }



    void spawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position, spawnPoint.rotation);
    }

}
