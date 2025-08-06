using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompararArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] arreglo1 = new int[5];
    public int[] arreglo2 = new int[5];
    public System.Collections.Generic.List<int> iguales = new System.Collections.Generic.List<int>();

    System.Random rnd = new System.Random();

    void Start()
    {
        // Llenar arreglos
        for (int i = 0; i < 5; i++)
        {
            arreglo1[i] = rnd.Next(10);
            arreglo2[i] = rnd.Next(10);
        }

        // Mostrar arreglos
        Debug.Log("Arreglo 1:");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(arreglo1[i]);
        }

        Debug.Log("Arreglo 2:");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(arreglo2[i]);
        }

        // Comparar y llenar lista
        for (int i = 0; i < 5; i++)
        {
            if (System.Array.Exists(arreglo2, x => x == arreglo1[i]))
            {
                if (!iguales.Contains(arreglo1[i]))
                {
                    iguales.Add(arreglo1[i]);
                }
            }
        }

        // Resultado
        if (iguales.Count > 3)
        {
            Debug.Log("¡Felicidades! Hay más de 3 coincidencias.");
        }
        else if (iguales.Count > 0)
        {
            Debug.Log("Coincidencias encontradas:");
            foreach (int n in iguales)
            {
                Debug.Log(n);
            }
        }
        else
        {
            Debug.Log("No hay datos repetidos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
