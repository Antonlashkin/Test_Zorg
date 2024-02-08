using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemyPrefabs = new List<GameObject>();
    [SerializeField] private int countOfEnemys;
    private GameObject _enemy;

    void Start()
    {
        for (int i = 0; i < countOfEnemys; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        _enemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)], transform);
        if (Random.Range(0, 2) == 0)
        {
            if (Random.Range(0, 2) == 0)
            {
                _enemy.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(0, Random.Range(0, Camera.main.pixelHeight), 10));
            }
            else
            {
                _enemy.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Random.Range(0, Camera.main.pixelHeight), 10));
            }
        }
        else
        {
            if (Random.Range(0, 2) == 0)
            {
                _enemy.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Camera.main.pixelWidth), 0, 10));
            }
            else
            {
                _enemy.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Camera.main.pixelWidth), Camera.main.pixelHeight, 10));
            }
        }

    }
}
