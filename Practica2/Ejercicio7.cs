using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour {
    // Start is called before the first frame update
  void Start() {
      
  }

  // Update is called once per frame
  void Update() {
    Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    if (Input.GetKeyDown(KeyCode.C)) {
      GameObject cilindro = GameObject.FindWithTag("cilindro");
      cilindro.GetComponent<Renderer>().material.color = randomColor;
    } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
      GameObject cubo = GameObject.FindWithTag("cubo");
      cubo.GetComponent<Renderer>().material.color = randomColor;
    }
  }
}
