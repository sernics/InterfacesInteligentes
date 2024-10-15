using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour {
  public float speed = 0.5f;
  // Start is called before the first frame update
  void Start() {
  }

  // Update is called once per frame
  void Update() {
    GameObject cube = GameObject.FindWithTag("cube");
    GameObject sphere = GameObject.FindWithTag("sphere");
    // Hacer que el cubo se mueva hacia la esfera
    if (this.speed < 1) {
      this.speed = 1;
    }
    cube.transform.position = Vector3.MoveTowards(cube.transform.position, sphere.transform.position, this.speed * Time.deltaTime);
  }
}
