using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> lista = new List<int>();


        for (int i = 0; i < 10; i++)
        {
            lista.Add(Random.Range(0, 101));
            Debug.Log("Posicion " + i + " = " + lista[i]);
        }

        int menor = lista[0];
        for (int i = 1; i < lista.Count; i++)
        {
            if (lista[i] < menor)
                menor = lista[i];
        }

        Debug.Log("El número más pequeño es: " + menor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
