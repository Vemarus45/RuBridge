using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[ExecuteInEditMode]
public class Point : MonoBehaviour
{
    public bool Runtime = true;

    void Update()
    {
        if (transform.hasChanged == true)
        {
            transform.hasChanged = false;
            CryptoAPITransform.position = Vector3Int.RoundToInt(transform.position);
        }
    }
}
