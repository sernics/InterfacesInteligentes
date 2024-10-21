using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour {
  public int counter;
  void Start() {
    counter = 0;
  }
  void OnCollisionEnter(Collision collider) {
    if (collider.gameObject.name == "Egg_Green") {
      counter++;
      Debug.Log("Green eggs: " + counter);
    }
  }
}
