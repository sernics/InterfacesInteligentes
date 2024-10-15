using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
      // Usar fire 1
      if (Input.GetButton("Fire1")) { // Pulsando la h
        Debug.Log("Fire1");
      }
    }
}
