using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveToSphere2 : MonoBehaviour {
  public Notifier notifier;

  void Start() {
    notifier.OnNotify += MoveToSphere;
  }

  void MoveToSphere() {
    Debug.Log("Moving to sphere");
    StartCoroutine(MoveToSphereCoroutine());
  }

  IEnumerator MoveToSphereCoroutine() {
    GameObject sphere = GameObject.FindWithTag("SphereTipe2");
    if (sphere != null) {
      while (Vector3.Distance(transform.position, sphere.transform.position) > 0.1f) {
        transform.position = Vector3.MoveTowards(transform.position, sphere.transform.position, Time.deltaTime * 2.0f);
        yield return null;
      }
    } else {
      Debug.LogError("No GameObject found with tag 'SphereTipe2'.");
    }
  }
}
