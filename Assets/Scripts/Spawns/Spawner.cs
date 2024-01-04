using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private UnitMove _unitToSpawn;
    [SerializeField] private Transform _target;

    [SerializeField] private Vector3 _spawnPosition = new Vector3(-7f, -0.6f);

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnUnit();
        }
    }

    private void SpawnUnit()
    {
        UnitMove spawnedUnit = Instantiate(_unitToSpawn, _spawnPosition, Quaternion.identity);
        spawnedUnit.SetTarget(_target);
    }
}
