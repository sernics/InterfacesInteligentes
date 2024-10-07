using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour {
  void Start() {
    
  }

  void CambiarColor() {
    GameObject cubo = GameObject.FindWithTag("cubo");
    GameObject[] esferas = GameObject.FindGameObjectsWithTag("tipo2");
    Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    GameObject lejano = null;
    float distancia = 0;
    foreach (GameObject esfera in esferas) {
      float d = Vector3.Distance(cubo.transform.position, esfera.transform.position);
      if (d > distancia) {
        distancia = d;
        lejano = esfera;
      }
    }
    lejano.GetComponent<Renderer>().material.color = randomColor;
  }

  void Update() {
    // if (Input.GetKeyDown(KeyCode.Space)) {
    if (Input.GetKeyDown(KeyCode.Q)) {
      CambiarColor();
    }
  }
}
