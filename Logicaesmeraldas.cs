using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logicaesmeraldas : MonoBehaviour
{
    // Este script controla la lógica de las esmeraldas en el juego

    public int numDeObjetivos; // Número de objetivos que deben ser recolectados
    public TextMeshProUGUI textoMision; // Referencia al texto de la misión
    public GameObject botonDeMision; // Referencia al botón de la misión

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length; // Obtener el número de objetivos en el inicio del juego
        textoMision.text = "Simon dice: Busca y recoge las esmeraldas de color rojo" +
                       "\n Restantes: " + numDeObjetivos; // Actualizar el texto de la misión con el número de objetivos restantes
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "objetivo") // Comprobar si el objeto que colisionó tiene la etiqueta "objetivo"
        {
            Destroy(col.transform.parent.gameObject); // Destruir el padre del objeto colisionado (el objetivo)
            numDeObjetivos--; // Disminuir el número de objetivos restantes
            textoMision.text = "Simon dice: Busca y recoge las esmeraldas de color rojo" +
                       "\n Restantes: " + numDeObjetivos; // Actualizar el texto de la misión con el número de objetivos restantes
            if (numDeObjetivos <= 0) // Si no quedan objetivos restantes
            {
                textoMision.text = " Bien hecho!! Da click en el boton siguiente para cargar la nueva pregunta"; // Actualizar el texto de la misión
                botonDeMision.SetActive(true); // Activar el botón de la misión
                Time.timeScale = 0f; // Detener el tiempo (pausar el juego)
            }
        }
    }
}
