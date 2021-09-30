using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private AudioSource _jumpSound;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask WhatIsGround;

    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    private bool _isGrounded;
    private const string IsRunning = "isRunning";

    //public LayerMask WhatIsGround;
    //public float CheckRadius;

    private void Start()
    {
        _animator = GetComponent<Animator>(); 
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _animator.SetBool(IsRunning, false);

        if (Input.GetButton("Horizontal"))
            Move();

        if (_isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
            _jumpSound.Play();
        }
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.1f, WhatIsGround);
    }

    private void Move()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal"); // вынести в поле

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, _speed * Time.deltaTime);

        if (direction.x < 0)
            _spriteRenderer.flipX = true;
        else
            _spriteRenderer.flipX = false;

        _animator.SetBool(IsRunning, true);
    }

    private void Jump()
    {
       // _jumpsCount--;
       // if (_jumpsCount > 0)
      //  {
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
      //  }
      //  else if (_jumpsCount == 0 && _isGrounded)
     //   {
       //     _rigidbody2D.velocity = Vector2.up * _jumpForce;
      //  }
        //_rigidbody2D.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        
    }

    //private void CheckGround()
    //{
    //    Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.85f); //попробавfdnm переписать
    //    if (collider.Length > 1)
    //        _isGrounded = true;
    //    else
    //        _isGrounded = false;
    //}
}