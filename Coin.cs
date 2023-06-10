using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Este script se encarga de manejar la recogida de objetos en el juego

    public int valor = 1;  // Valor de los diferentes objetos, monedas, esmeraldas o esferas (puntos que se sumar�n al recogerla)
    public GameManager gameManager; // Referencia al GameManager

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  // Verificar si el objeto que colision� tiene la etiqueta "Player"
        {
            gameManager.SumarPuntos(valor); // Llamar al m�todo SumarPuntos del GameManager y pasarle el valor del objeto
            Destroy(this.gameObject); // Destruir el objeto
        }

    }
}
