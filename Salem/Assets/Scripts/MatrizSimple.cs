using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrizSimple : MonoBehaviour
{
    // Start is called before the first frame update
    public int[,] matriz = new int[3, 3];
    System.Random rnd = new System.Random();
    void Start()
    {
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                matriz[fila, columna] = rnd.Next(100);
                Debug.Log("Fila " + fila + " Columna " + columna + " valor: " + matriz[fila, columna]);
            }
        }

        int x = rnd.Next(3);
        int y = rnd.Next(3);

        Debug.Log("Número aleatorio en [" + x + "," + y + "] es: " + matriz[x, y]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
