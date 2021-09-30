using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        coin.CoinCollected -= OnCoinCollected;
        _player.AddPoint(_pointForCollectCoin);
        _player.CollectSound(); // вынести в класс плееаро

    }
}