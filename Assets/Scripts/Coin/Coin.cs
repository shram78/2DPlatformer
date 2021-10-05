using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.AddScore();
            Die();
        }
    }

    private void Die()
    {
        _coinSound.Play();
        Destroy(gameObject, 0.3f);
    }
}