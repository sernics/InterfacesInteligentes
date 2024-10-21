using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public Ejercicio5 ejercicio5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tengo un canva que quiero que tenga el mismo valor que el contador de huevos verdes
        // Para ello, necesito acceder al script de Ejercicio5 y obtener el valor de la variable counter
        int counter = ejercicio5.counter;
        
        // Asignar el valor de counter al texto del canvas (gameObject)
        GameObject canvas = gameObject;
        if (canvas != null) {
            canvas.GetComponent<UnityEngine.UI.Text>().text = "Counter: " + counter;
        } else {
            Debug.LogError("No GameObject found with tag 'Canvas'.");
        }        
    }
}
