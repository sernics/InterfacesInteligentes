using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7 : MonoBehaviour {
  public float speed = 0.5f;
  // Start is called before the first frame update
  void Start() {
  }

  // Update is called once per frame
  void Update() {
    GameObject cube = GameObject.FindWithTag("cube");
    GameObject sphere = GameObject.FindWithTag("sphere");

    // Mover la esfera con las teclas w-s (vertical) y a-d (horizontal)
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
    

    // Hacer que el cubo se mueva hacia la esfera
    if (this.speed < 1) {
      this.speed = 1;
    }

    // Hacer que el cubo mire hacia la esfera
    cube.transform.LookAt(sphere.transform.position);
    cube.transform.position = Vector3.MoveTowards(cube.transform.position, sphere.transform.position, this.speed * Time.deltaTime);
  }
}
