using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public int[] salem = new int[10];

    void Start()
    {
        for (int i = 0; i < salem.Length; i++)
        {
            salem[i] = i + 1;
            Debug.Log("Posición " + i + " contiene: " + salem[i]);
        }
    }
}

