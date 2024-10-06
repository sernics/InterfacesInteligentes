using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
  // Variable pública para definir la cantidad de frames de espera
  public int waitFrames = 120;
  private int counter = 0;

  // Start is called before the first frame update
  void Start() {
    counter = 0;
  }

  // Update is called once per frame
  void Update() {
    if (counter == waitFrames) {
      // Crear un vector de color de 3 valores aleatorios
      Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
      // Asignar el color aleatorio al material del objeto
      GetComponent<Renderer>().material.color = randomColor;
      counter = 0;
    } else {
      counter++;
    }
  }
}
