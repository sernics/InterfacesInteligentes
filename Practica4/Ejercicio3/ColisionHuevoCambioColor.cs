using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionHuevoCambioColor : MonoBehaviour {
  public GameObject target;
  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "SpyderType2") {
      // Cambiar el color de target aleatoriamente
      Renderer renderer = target.GetComponent<Renderer>();
      renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
  }
}