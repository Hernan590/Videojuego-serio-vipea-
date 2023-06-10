using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logicamonedamala : MonoBehaviour
{
    // Este script controla la lógica de las monedas malas en el juego

    public int numDeObjetivosmalos; // Número de objetivos malos que deben ser alcanzados
    public GameObject botonrepetir; // Referencia al botón para repetir el juego
    public GameObject anuncio1; // Referencia al anuncio

    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivosmalos = GameObject.FindGameObjectsWithTag("objetivomalo").Length; // Obtener el número de objetivos malos en el inicio del juego
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "objetivomalo") // Comprobar si el objeto que colisionó tiene la etiqueta "objetivomalo"
        {
            Destroy(col.transform.parent.gameObject); // Destruir el padre del objeto colisionado
            numDeObjetivosmalos--; // Disminuir el número de objetivos malos restantes
            if (numDeObjetivosmalos <= 0) // Si no quedan objetivos malos restantes
            {
                anuncio1.SetActive(true); // Mostrar el anuncio
                botonrepetir.SetActive(true); // Mostrar el botón para repetir el juego
                Time.timeScale = 0f; // Detener el tiempo (pausar el juego)
            }
        }
    }
}
