using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour {
  public Vector3 fistVariable;
  public Vector3 secondVariable;
  // Start is called before the first frame update
  void Start() {
    // Imprimir las magnitudes de los vectores
    Debug.Log("Magnitud del primer vector: " + fistVariable.magnitude);
    Debug.Log("Magnitud del segundo vector: " + secondVariable.magnitude);
    // Imprimir el angulo entre los vectores
    Debug.Log("Ángulo entre los vectores: " + Vector3.Angle(fistVariable, secondVariable));
    // Imprimir la distancia entre los vectores
    Debug.Log("Distancia entre los vectores: " + Vector3.Distance(fistVariable, secondVariable));
    // Imprimir un mensaje indicando que vector esta a una altura mayor
    if (fistVariable.y > secondVariable.y) {
      Debug.Log("El primer vector está a una altura mayor que el segundo");
    } else if (fistVariable.y < secondVariable.y) {
      Debug.Log("El segundo vector está a una altura mayor que el primero");
    } else {
      Debug.Log("Ambos vectores están a la misma altura");
    }
  }

  // Update is called once per frame
  void Update() {
      
  }
}
