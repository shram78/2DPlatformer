using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Player _player;
    
    private void Start()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemyPrefab, _spawnPoints[i]);
        }
    }
}