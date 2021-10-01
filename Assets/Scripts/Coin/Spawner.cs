using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Coin))]

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Player _player;

    private int _pointForCollectCoin = 10;

    private void Start()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Coin coin = Instantiate(_coinPrefab, _spawnPoints[i]);
            coin.CoinCollected += OnCoinCollected;
        }
    }

    private void OnCoinCollected(Coin coin)
    {
        _player.AddPoint(_pointForCollectCoin); 
        coin.CoinCollected -= OnCoinCollected;
    }
}