using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyMove _enemyToSpawn;
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _spawnPosition = new Vector3(-7f, -0.6f);

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < 15; i++)
        {
            EnemyMove _spawnedEnemy = Instantiate(_enemyToSpawn, _spawnPosition, Quaternion.identity);
            _spawnedEnemy.transform.Rotate(0f, 180f, 0f);
            _spawnedEnemy.SetTarget(_target);
            yield return new WaitForSeconds(2f);
        }
    }
}
