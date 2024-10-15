using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio12 : MonoBehaviour {
  public float speed = 2f;

  // Start is called before the first frame update
  void Start() {
      
  }

  // Update is called once per frame
  void Update() {
    // Va hacia delante al pulsar la tecla W
    if (Input.GetKey(KeyCode.W)) {
      gameObject.transform.position += transform.forward * speed * Time.deltaTime;
    }
    // Va hacia atrás al pulsar la tecla S
    if (Input.GetKey(KeyCode.S)) {
      gameObject.transform.position -= transform.forward * speed * Time.deltaTime;
    }
    // Gira a la izquierda al pulsar la tecla A (usando quaternions)
    if (Input.GetKey(KeyCode.A)) {
      gameObject.transform.rotation *= Quaternion.Euler(0, -speed * Time.deltaTime * 50, 0);
    }
    // Gira a la derecha al pulsar la tecla D (usando quaternions)
    if (Input.GetKey(KeyCode.D)) {
      gameObject.transform.rotation *= Quaternion.Euler(0, speed * Time.deltaTime * 50, 0);
    }
  }
}
