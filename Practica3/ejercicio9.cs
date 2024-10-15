using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio9 : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
      
  }

  // Update is called once per frame
  void OnCollisionEnter(Collision collision) {
    string name = collision.gameObject.name;
    if (name == "Cube" || name == "Sphere") {
      Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
  }

  void Update() {
    // Hacer que el cubo y la esfera miren hacia el cilindro
    GameObject.FindWithTag("cube").transform.LookAt(GameObject.FindWithTag("cilindre").transform.position);
    GameObject.FindWithTag("sphere").transform.LookAt(GameObject.FindWithTag("cilindre").transform.position);
    // Hacer que el cubo y la esfera se muevan hacia el cilindro
    GameObject.FindWithTag("cube").transform.position = Vector3.MoveTowards(GameObject.FindWithTag("cube").transform.position, GameObject.FindWithTag("cilindre").transform.position, 1 * Time.deltaTime);
    GameObject.FindWithTag("sphere").transform.position = Vector3.MoveTowards(GameObject.FindWithTag("sphere").transform.position, GameObject.FindWithTag("cilindre").transform.position, 2 * Time.deltaTime);
  }
}
