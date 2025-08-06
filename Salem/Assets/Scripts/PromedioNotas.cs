using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromedioNotas : MonoBehaviour
{
    public float[] notas = { 3.5f, 4.0f, 4.5f, 3.0f, 4.2f };
    public float suma;
    public float promedio;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        promedio = suma / notas.Length;

        Debug.Log("El promedio es: " + promedio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
