using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCylinder : MonoBehaviour {
  public Notifier notifier;
  // Start is called before the first frame update
  void Start() {
    notifier.OnNotify += MoveTo;
  }

  void MoveTo() {
    Debug.Log("Movint to cylinder");
    StartCoroutine(MoveToCylynderCorrutine());
  }
  IEnumerator MoveToCylynderCorrutine() {
    GameObject cylinder = GameObject.FindWithTag("cylinder");
    if (cylinder != null) {
      while (Vector3.Distance(transform.position, cylinder.transform.position) > 0.1f) {
        transform.position = Vector3.MoveTowards(transform.position, cylinder.transform.position, Time.deltaTime * 2.0f);
        yield return null;
      }
    } else {
      Debug.LogError("No GameObject found with tag 'Cylinder'.");
    }
  }
}
