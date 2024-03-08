using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<Vector2, Point> AllPoints = new Dictionary<Vector2, Point>();

    private void Awake()
    {
        AllPoints.Clear();
    }
}
