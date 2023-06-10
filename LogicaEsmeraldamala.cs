using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaEsmeraldamala : MonoBehaviour
{
    // Este script controla la l�gica de las esmeraldas malas en el juego

    public int numDeObjetivosmalos; // N�mero de objetivos malos que deben ser destruidos
    public GameObject botonrepetir; // Referencia al bot�n para repetir
    public GameObject anuncio1; // Referencia al objeto de anuncio

    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivosmalos = GameObject.FindGameObjectsWithTag("objetivomalo").Length; // Obtener el n�mero de objetivos malos en el inicio del juego
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "objetivomalo") // Comprobar si el objeto que colision� tiene la etiqueta "objetivomalo"
        {
            Destroy(col.transform.parent.gameObject); // Destruir el padre del objeto colisionado (el objetivo malo)
            numDeObjetivosmalos--; // Disminuir el n�mero de objetivos malos restantes

            if (numDeObjetivosmalos <= 0) // Si no quedan objetivos malos restantes
            {
                anuncio1.SetActive(true); // Mostrar el objeto de anuncio
                botonrepetir.SetActive(true); // Mostrar el bot�n para repetir
                Time.timeScale = 0f; // Detener el tiempo (pausar el juego)
            }
        }
    }
}
