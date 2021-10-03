using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Coin))]

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Player _player;

    private void Start()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_coinPrefab, _spawnPoints[i]);
        }
    }
}