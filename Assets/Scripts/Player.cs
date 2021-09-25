using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction CoinCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            CoinCollected?.Invoke();
    }


}