using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour {   
  public Vector3 cubeTarget;
  public Vector3 sphereTarget;
  public Vector3 cylinderTarget;
  // Start is called before the first frame update
  void Start() {
  }

  // Update is called once per frame
  void Update() {
    GameObject cubo = GameObject.FindWithTag("cubo");
    GameObject esfera = GameObject.FindWithTag("esfera");
    GameObject cilindro = GameObject.FindWithTag("cilindro");
    if (Input.GetKeyDown(KeyCode.Space)) {
      cubo.transform.position = cubeTarget;
      esfera.transform.position = sphereTarget;
      cilindro.transform.position = cylinderTarget;
    }
  }
}
