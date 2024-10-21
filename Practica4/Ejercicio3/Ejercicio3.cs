using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour {
  public GameObject targetObject;

  // Start is called before the first frame update
  void Start() {
    if (targetObject == null) {
      Debug.LogError("Target object is not assigned.");
    }
  }

  // Update is called once per frame
  void Update() {
      
  }

  void OnCollisionEnter(Collision collider) {
    if (collider.gameObject.tag == "SpyderType2") {
      // SpyderType1 moveTo Objeto seleccionado
      GameObject[] spyders = GameObject.FindGameObjectsWithTag("SpyderType1");
      foreach (GameObject spyder in spyders) {
        StartCoroutine(MoveToSelectedObject(spyder, this.targetObject));
      }
    } else if (collider.gameObject.tag == "SpyderType1") {
      // SpyderType2 moveTo Huevos tipo 2 
      GameObject egg = GameObject.FindWithTag("EggType2");
      GameObject[] spyders = GameObject.FindGameObjectsWithTag("SpyderType2");
      Debug.Log("SpyderType2 moveTo Huevos tipo 2");
      foreach (GameObject spyder in spyders) {
        StartCoroutine(MoveToSelectedObject(spyder, egg));
      }
    } 
  }
  IEnumerator MoveToSelectedObject(GameObject spyder, GameObject targetObject = null) {
    if (targetObject != null) {
      while (Vector3.Distance(spyder.transform.position, targetObject.transform.position) > 0.1f) {
        spyder.transform.position = Vector3.MoveTowards(spyder.transform.position, targetObject.transform.position, Time.deltaTime * 2.0f);
        yield return null;
      }
    } else {
      Debug.LogError("No GameObject found with tag 'SpyderType1'.");
    }
  }
}
