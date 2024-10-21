using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour {
  public delegate void Notify();
  public event Notify OnNotify;

  void Start() {
  }

  void Update() {
    
  }
  void OnCollisionEnter(Collision collider) {
    if (collider.gameObject.name == "Cylinder") {
      OnNotify?.Invoke();
    }
  }
}