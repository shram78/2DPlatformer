using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Points { get; private set; }

      public void AddPoint(int points)
    {
        Points += points;
        
        ShowPointsInDebug();
    }

    private void ShowPointsInDebug()
    {
        Debug.Log("Cобрано очков:" + Points);
    }
}