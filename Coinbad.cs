using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinbad : MonoBehaviour
{
    // Este script se encarga de manejar la recogida de objetos equivocados en el juego

    public int valor = 1;  // Valor del objeto equivocado u objetos que simon no esta solicitando (puntos que se sumaran al recogerla)
    public GameManagerBad gameManagerBad; // Referencia al GameManagerBad

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verificar si el objeto que colisionó tiene la etiqueta "Player"
        {
            gameManagerBad.SumarPuntosmalos(valor); // Llamar al método SumarPuntosmalos del GameManagerBad y pasarle el valor del objeto equivocado
            Destroy(this.gameObject); // Destruir la moneda mala
        }

    }
}
