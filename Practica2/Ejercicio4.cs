using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    // Muestra en pantalla el vector con la posición de la esfera.
    Debug.Log("Posición de la esfera: " + GetComponent<Transform>().position);
  }

  // Update is called once per frame
  void Update() {
      
  }
}
