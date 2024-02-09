using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<EnemyScriptableObject> enemyConfigs = new List<EnemyScriptableObject>();
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] private int countOfEnemys;
    private GameObject _enemy;

    void Start()
    {
        for (int i = 0; i < countOfEnemys; i++)
        {
            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {
        _enemy = Instantiate(enemyPrefabs, transform);
        EnemyScriptableObject enemyConfig = enemyConfigs[Random.Range(0, enemyConfigs.Count)];

        _enemy.GetComponent<EnemyMove>().SetSpeed(enemyConfig.speed);
        _enemy.GetComponent<EnemyAtack>().SetDamage(enemyConfig.damage);
        _enemy.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = enemyConfig.sprite;
        _enemy.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<EnemyHealthManager>().SetHealth(enemyConfig.health);

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
