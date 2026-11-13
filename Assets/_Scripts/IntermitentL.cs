using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermitentL : MonoBehaviour
{
    private Light luz; // Variable para almacenar la referencia al componente Light de la luz que se va a parpadear
    public float esperaMinima = 0.05f; // Tiempo mínimo apagada/encendida
    public float esperaMaxima = 0.2f;  // Tiempo máximo apagada/encendida

    void Start()
    {
        // Obtiene la referencia al componente Light de la luz utilizando el método GetComponent, lo que permite controlar su estado (encendida o apagada) para crear el efecto de parpadeo
        luz = GetComponent<Light>();
        // Inicia la corrutina que controla el ciclo de parpadeo de la luz, lo que permite que la luz cambie de estado (encendida o apagada) de manera aleatoria para crear un efecto de parpadeo más natural y menos predecible
        StartCoroutine(CicloParpadeo());
    }
    // Corrutina que controla el ciclo de parpadeo de la luz, alternando su estado (encendida o apagada) y esperando un tiempo aleatorio entre cada cambio de estado para crear un efecto de parpadeo más natural y menos predecible
    IEnumerator CicloParpadeo()
    {
        while (true) // Bucle infinito
        {
            // Cambia el estado (si está encendida, la apaga; si está apagada, la enciende)
            luz.enabled = !luz.enabled;
            
            // Espera un tiempo aleatorio para que el parpadeo no sea rítmico
            float tiempoAleatorio = Random.Range(esperaMinima, esperaMaxima);
            yield return new WaitForSeconds(tiempoAleatorio);
        }
    }
}
