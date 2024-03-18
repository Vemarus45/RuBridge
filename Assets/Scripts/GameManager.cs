using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Dictionary<Vector2, Point> AllPoints = new Dictionary<Vector2, Point>();

    private void Awake()
    {
        AllPoints.Clear();
        Time.timeScale = 0;
    }

    [ContextMenu("Test GamePlay")]
    public void Play()
    {
        Time.timeScale = 1;
    }
}
