using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
  public int velocidad;
  // Start is called before the first frame update
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey(KeyCode.UpArrow)) {
      Debug.Log("UpArrow: " + velocidad * Input.GetAxis("Vertical"));
    }
    if (Input.GetKey(KeyCode.DownArrow)) {
      Debug.Log("DownArrow: " + velocidad * Input.GetAxis("Vertical"));
    }
    if (Input.GetKey(KeyCode.LeftArrow)) {
      Debug.Log("LeftArrow: " + velocidad * Input.GetAxis("Horizontal"));
    }
    if (Input.GetKey(KeyCode.RightArrow)) {
      Debug.Log("RightArrow: " + velocidad * Input.GetAxis("Horizontal"));
    }
  }
}
