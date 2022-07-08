using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManag : MonoBehaviour
{
    public GameObject[] projectiles;
    public float repeatEnemyRate = 2.0f, spawnRange = 8.0f;
    private int randomEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeEnemy", 0.1f, repeatEnemyRate);
    }

    private void MakeEnemy()
    {
        randomEnemy = Random.Range(0,3);
        Instantiate(projectiles[randomEnemy], RandomPos(), projectiles[randomEnemy].transform.rotation);
    }

    private Vector2 RandomPos()
    {
        return new Vector2(Random.Range(-spawnRange, spawnRange), 5.5f);
    }
}
