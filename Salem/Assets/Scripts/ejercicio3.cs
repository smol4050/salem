using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio3 : MonoBehaviour
{
    public TMP_InputField inputField;  // Campo de texto para escribir frases
    public TMP_Text displayText;       // Texto para mostrar la frase actual
    public Button addButton;           // Botón "Agregar"
    public Button retroButton;         // Botón "Retroceder"

    private Stack<string> pila = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {
        addButton.onClick.AddListener(AgregarFrase);
        retroButton.onClick.AddListener(Retroceder);
        ActualizarTexto();
    }

    void AgregarFrase()
    {
        string frase = inputField.text;
        if (string.IsNullOrEmpty(frase)) return;

        pila.Push(frase);   // Guardar frase en la pila
        inputField.text = "";
        ActualizarTexto();
    }

    void Retroceder()
    {
        if (pila.Count > 0)
            pila.Pop();    // Elimina la última frase

        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        if (pila.Count == 0)
            displayText.text = "(Sin frases)";
        else
            displayText.text = pila.Peek(); // Muestra la última frase guardada
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
