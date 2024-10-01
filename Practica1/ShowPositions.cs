using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPositions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Obtener un objeto por el tag
        GameObject[] objects = GameObject.FindGameObjectsWithTag("RioCharacter");
        GameObject[] cubo = GameObject.FindGameObjectsWithTag("MagicCube");
        GameObject[] cosaRosa = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject obj in objects)
        {
            Debug.Log("Posicion de Rio: " + obj.transform.position);
        }
        foreach (GameObject obj in cubo)
        {
            Debug.Log("Posicion de Cubo: " + obj.transform.position);
        }
        foreach (GameObject obj in cosaRosa)
        {
            Debug.Log("Posicion de Cosa Rosa: " + obj.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
