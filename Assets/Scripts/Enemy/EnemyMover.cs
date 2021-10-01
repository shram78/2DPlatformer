using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _whatIsGround;

    private SpriteRenderer _spriteRenderer;
    private bool _isGrounded;
    private Vector3 _directionMove;

    //private void Start()
    //{
    //    _spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _whatIsGround);
    }

    private void Move()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

       //if (_isGrounded == true)
        //{
        //_directionMove = transform.right * _speed * 1;

        //}


        //transform.position = Vector3.MoveTowards(transform.position, transform.position + _directionMove, _speed * Time.deltaTime);

        //if (_directionMove.x < 0)
        //    _spriteRenderer.flipX = true;

        //else
        //    _spriteRenderer.flipX = false;

    }
}