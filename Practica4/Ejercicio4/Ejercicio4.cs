using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour {
  public GameObject teleportObject;
  public GameObject target;
  // Start is called before the first frame update
  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name ==  target.gameObject.name) {
      // Teleport all spyders with tag "SpyderType1" to teleportObject
      GameObject[] spyders = GameObject.FindGameObjectsWithTag("SpyderType1");
      foreach (GameObject spyder in spyders) {
        spyder.transform.position = teleportObject.transform.position;
      }
      // Rotate all spyders with tag "SpyderType2" to being looking at the teleportObject
      GameObject[] spyders2 = GameObject.FindGameObjectsWithTag("SpyderType2");
      foreach (GameObject spyder in spyders2) {
        Vector3 direction = teleportObject.transform.position - spyder.transform.position;
        direction.y = 0; // Keep the y-axis rotation unchanged
        spyder.transform.rotation = Quaternion.LookRotation(direction);
      }
    }
  }
}
