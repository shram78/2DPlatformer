﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public event UnityAction<Coin> CoinCollected;

    [SerializeField] private AudioSource _coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            CoinCollected?.Invoke(this);
            Die();
        }
    }

    private void Die()
    {
        _coinSound.Play();
        Destroy(gameObject, 0.3f);
    }
}