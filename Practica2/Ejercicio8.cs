using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour {
  public int aumento = 3;

  void Start() {
    aumentarMasCercana();
  }

  void aumentarMasCercana() {
    GameObject cubo = GameObject.FindWithTag("cubo");
    GameObject[] esferas = GameObject.FindGameObjectsWithTag("tipo2");
    GameObject cercana = null;
    float distancia = float.MaxValue;
    foreach (GameObject esfera in esferas) {
      float d = Vector3.Distance(cubo.transform.position, esfera.transform.position);
      if (d < distancia) {
        distancia = d;
        cercana = esfera;
      }
    }
    // Aumentar la altura de la esfera más cercana
    Vector3 pos = cercana.transform.position;
    pos.y += aumento;
    cercana.transform.position = pos;
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
