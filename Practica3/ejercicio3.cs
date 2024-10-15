using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour {
  public Vector3 moveDirection = Vector3.forward; // Vector de dirección del movimiento
  public float speed = 1.0f; // Velocidad del movimiento

  // Start is called before the first frame update
  void Start() {
    // Asegurarse de que la velocidad inicial sea mayor que 1
    if (speed <= 1.0f) {
      speed = 1.1f;
    }

    // Inicializar la posición del cubo en y=0
    Vector3 startPosition = transform.position;
    startPosition.y = 0;
    transform.position = startPosition;
  }

  // Update is called once per frame
  void Update() {
    // Trasladar el cubo en cada iteración
    transform.Translate(moveDirection * speed * Time.deltaTime);
  }
}
