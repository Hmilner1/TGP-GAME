using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaveSystem : MonoBehaviour
{
    public static int Enemiesonthemap = 0;
    public int enemiesontheMap;

    public Wave[] waves;

    public Transform[] SpawnPoint;
    ObjectPooler pool;

    [SerializeField] public float timeBetweenWaves = 5f;
    [SerializeField] private float countdown = 20f;

    [SerializeField] private int waveNumber = 0;
    [SerializeField] private int MaxWaves = 20;
    [SerializeField] int xpos;
    [SerializeField] int ypos;

    private void Start()
    {
        pool = FindObjectOfType<ObjectPooler>();
    }

    private void Update()
    {
        enemiesontheMap = Enemiesonthemap;

        if (Enemiesonthemap > 0)
        {
            return;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWaveFromTeleporter1());
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
    }

    IEnumerator SpawnWaveFromTeleporter1()
    {

        if (waves.Length > waveNumber)
        {
            Wave wave = waves[waveNumber];
            for (int z = 0; z < wave.enemies.Length; z++)
            {
                for (int i = 0; i < wave.enemies[z].count; i++)
                {
                    SpawnEnemy(wave.enemies[z].enemy);
                    yield return new WaitForSeconds(1f / wave.spawnRate);
                }
            }
            waveNumber++;
        }
    }

    void SpawnEnemy(GameObject enemyPrefab)
    {
        Vector3 SpawnSpread = SpawnPoint[0].transform.position;
        SpawnSpread.x += Random.Range(1, 50);
        SpawnSpread.z += Random.Range(1, 50);

        GameObject enemy = pool.GetObject(enemyPrefab);
        enemy.GetComponent<NavMeshAgent>().Warp(SpawnPoint[0].transform.position);
        Enemiesonthemap++;
    }
}
