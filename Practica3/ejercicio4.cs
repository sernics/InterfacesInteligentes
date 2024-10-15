using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour {
  public float speed = 5.0f;

  // Update is called once per frame
  void Update() {
    // Movimiento del cubo con las teclas de flecha
    // tag cube
    GameObject cube = GameObject.FindWithTag("cube");
    float moveHorizontalCube = Input.GetAxis("Horizontal");
    float moveVerticalCube = Input.GetAxis("Vertical");
    cube.transform.Translate(new Vector3(moveHorizontalCube, moveVerticalCube, 0) * speed * Time.deltaTime);

    // Movimiento de la esfera con las teclas w-s (vertical) y a-d (horizontal)
    // tag sphere
    GameObject sphere = GameObject.FindWithTag("sphere");
    float moveHorizontalSphere = 0;
    float moveVerticalSphere = 0;

    if (Input.GetKey(KeyCode.W)) {
      moveVerticalSphere = 1;
    } else if (Input.GetKey(KeyCode.S)) {
      moveVerticalSphere = -1;
    }

    if (Input.GetKey(KeyCode.A)) {
      moveHorizontalSphere = -1;
    } else if (Input.GetKey(KeyCode.D)) {
      moveHorizontalSphere = 1;
    }

    sphere.transform.Translate(new Vector3(moveHorizontalSphere, moveVerticalSphere, 0) * speed * Time.deltaTime); // El 5 me lo salto porque lo de ajustarlo al tiempo ya lo habia hecho
  }
}
