using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;
    

    public int Point { get; private set; }

    public void AddPoint(int point)
    {
        Point += point;
        Debug.Log("Cобрано очков:" + Point);
    }

    public void CollectSound()
    {
        _coinSound.Play();
    }
        
 
}