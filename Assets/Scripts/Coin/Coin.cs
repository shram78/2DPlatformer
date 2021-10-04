using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;

    private Player _player;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _player.AddScore();
            Die();
        }
    }

    private void Die()
    {
        _coinSound.Play();
        Destroy(gameObject, 0.3f);
    }

    public void Init(Player player)
    {
        _player = player;
    }
}