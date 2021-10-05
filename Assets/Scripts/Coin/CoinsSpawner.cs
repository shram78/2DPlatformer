using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Coin))]

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Coin coin = Instantiate(_coinPrefab, _spawnPoints[i]);
        }
    }
}