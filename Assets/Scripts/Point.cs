using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[ExecuteInEditMode]
public class Point : MonoBehaviour
{
    public bool Runtime = true;
    public List<Bar> ConnectedBars;

    void Update()
    {
        if (transform.hasChanged == true)
        {
            transform.hasChanged = false;
            transform.position = Vector3Int.RoundToInt(transform.position);
        }
    }
}
