using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public GameObject blueEnemy;
    public GameObject redEnemy;
    private GameObject spawned;

    public float spawnRate = 0.2f;
    private float nextSpawn;
    public string lane = "short";

    public Transform BlueSpawnPoint;

    public float timeBetweenWaves = 5f;
    //private float countdown = 5f;
    private int waveNumber;
    //LaneSelector lane;

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            lane = "short";
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            lane = "long";
        }

        if (Input.GetKey(KeyCode.A) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnBlueEnemmy();
        }
        if (Input.GetKey(KeyCode.Z) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnRedEnemmy();
        }
        /*if (countdown <= 0f)
        {
            StartCoroutine(SpawnWaves());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
        */
    }
    /*
    IEnumerator SpawnWaves()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemmy();
            yield return new WaitForSeconds(0.5f);
        }

        waveNumber++;
    }
    */
    void SpawnBlueEnemmy()
    {
        spawned = Instantiate(blueEnemy, BlueSpawnPoint.position, BlueSpawnPoint.rotation);
        if (lane == "long")
        {
            spawned.AddComponent<EnemyLongBlue>();
        }
        if (lane == "short")
        {
            spawned.AddComponent<EnemyShortBlue>();
        }
    }

    void SpawnRedEnemmy()
    {
        spawned = Instantiate(redEnemy, BlueSpawnPoint.position, BlueSpawnPoint.rotation);
        if (lane == "long")
        {
            spawned.AddComponent<EnemyLongRed>();
        }
        if (lane == "short")
        {
            spawned.AddComponent<EnemyShortRed>();
        }
    }
}
