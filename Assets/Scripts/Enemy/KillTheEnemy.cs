using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class KillTheEnemy : MonoBehaviour
{
    private Animator _animator;

    private const string IsDestroy = "isDestroy";

    [SerializeField] private Player _player;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    //private void OnEnable()
    //{
    //    _player.EnemyCatched += Kill;
    //}

    //private void OnDisable()
    //{
    //    _player.EnemyCatched -= Kill;
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.TryGetComponent<Player>(out Player player))
    //    {
    //        Kill();
    //    }
    //}

    private void Kill()
    {
        Debug.Log("Crush Kill And Destroyd");


        _animator.SetBool(IsDestroy, true);
        Destroy(gameObject);
    }
}
