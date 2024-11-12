using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swords : MonoBehaviour
{
    public ObjectController oc;
    // Start is called before the first frame update
    void Start()
    {
        oc.OnNotify += Teleport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Teleport() {
        Debug.Log("Teleporting");
        // Teletransportar el propio gameObject (espada) a una posición aleatoria
        // en el rango de la sala
        float angle = Random.Range(-Mathf.PI, Mathf.PI);
        float distance = Random.Range(-2, 2);
        float height = Random.Range(-2, 2);
        Vector3 actualPosition = transform.position;
        // Nuevo vector con la suma de la posición actual y la nueva
        Vector3 newPos = new Vector3(actualPosition.x + Mathf.Cos(angle) * distance, actualPosition.y + height, actualPosition.z + Mathf.Sin(angle) * distance);
        transform.position = newPos;
    }
}
