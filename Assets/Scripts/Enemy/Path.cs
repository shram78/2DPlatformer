using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector2[] _waypoints;

    private void Start()
    {
        //Tween tween = transform.DOPath(_waypoints, 5, PathType.Linear).SetOptions(true).SetLookAt(1);
        //tween.SetEase(Ease.Linear).SetLoops(-1);


    }
}
