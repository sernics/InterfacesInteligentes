using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour {
    // Start is called before the first frame update
  void Start() {
    GameObject cubo = GameObject.FindWithTag("cubo");
    GameObject cilindro = GameObject.FindWithTag("cilindro");
    // Calcular la distancia entre el cubo y el cilindro
    float distancia = Vector3.Distance(cubo.transform.position, cilindro.transform.position);
    Debug.Log("La distancia entre el cubo y el cilindro es: " + distancia);
  }

  // Update is called once per frame
  void Update() {
      
  }
}
