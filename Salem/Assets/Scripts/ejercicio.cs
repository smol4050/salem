using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Random.Range(0, 101);
            Debug.Log("Position " + i + " = " + numeros[i]);
        }

        int mayor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];
        }

        Debug.Log("El número más grande es: " + mayor);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
