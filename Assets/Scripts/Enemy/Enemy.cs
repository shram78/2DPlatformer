using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Animator))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioSource _destroySound;

    private Player _player;

    private Animator _animator;
    private const string _isDestroy = "isDestroy";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            Die();
        }
    }

    private void Die()
    {
        int _pointForDestroyEnemy = 50;

        _animator.SetBool(_isDestroy, true);
        _destroySound.Play();
        _player.AddPoint(_pointForDestroyEnemy);
        Destroy(gameObject, 0.5f);
    }
}