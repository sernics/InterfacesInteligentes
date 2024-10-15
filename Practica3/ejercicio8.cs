using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio8 : MonoBehaviour {
  public float speed = 0.5f;
  // Start is called before the first frame update
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {
    gameObject.transform.position += transform.forward * speed * Time.deltaTime;
    gameObject.transform.Rotate(0, speed * Time.deltaTime * 50, 0); // Adjust the multiplier as needed for desired rotation speed
  }
}
