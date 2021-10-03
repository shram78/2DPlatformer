using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPatrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceDetectionGround;
    [SerializeField] private Transform _groundChecker;

    private bool _movingRight;
    private RaycastHit2D _groundInfo;

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

        _groundInfo = Physics2D.Raycast(_groundChecker.position, Vector2.down, _distanceDetectionGround);

        if (_groundInfo.collider == false)
        {
            if (_movingRight)
            {
                transform.eulerAngles = new Vector3(0, 180, 0); 
                _movingRight = false;
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                _movingRight = true;
            }
        }
    }
}