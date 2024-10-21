using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio7 : MonoBehaviour
{
    public Ejercicio5 ejercicio5;
    public int myCounter;
    public Text rewardText; // Referencia al componente Text del Canvas

    // Start is called before the first frame update
    void Start()
    {
        myCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        myCounter = ejercicio5.counter;
        if (myCounter % 2 == 0 && myCounter != 0) {
            // Mostrar el jugador obtenga una recompensa que se muestre en la UI.
            Debug.Log("Player gets a reward");

            // Asignar el valor de counter al texto del canvas (gameObject)
            if (rewardText != null) {
                rewardText.text = "Player gets a reward!";
                StartCoroutine(ClearRewardTextAfterDelay(5.0f)); // Clear the text after 1 second
            } else {
                Debug.LogError("No Text component found on the assigned GameObject.");
            }
        }
    }

    private IEnumerator ClearRewardTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        rewardText.text = "";
    }
}
