using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Nodice : MonoBehaviour
{
    //Este script controla los objetos en las misiones en donde no aparece la frase "Simnon dice"

    public int numDeObjetivos; // Cantidad de objetivos restantes
    public TextMeshProUGUI textoMision; // Referencia al objeto de texto para mostrar la misión
    public GameObject botonDeMision; // Referencia al botón de misión

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length; // Obtener la cantidad de objetivos iniciales
        textoMision.text = "Busca y recoge las esmeraldas de color amarillo" +
                        "\n Restantes: " + numDeObjetivos; // Establecer el texto inicial de la misión
    }

    // Update is called once per frame
    void Update()
    {
        // No hay implementación en este caso
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "objetivo") // Verificar si el objeto colisionado tiene la etiqueta "objetivo"
        {
            Destroy(col.transform.parent.gameObject); // Destruir el objeto colisionado y su objeto padre
            numDeObjetivos--; // Reducir la cantidad de objetivos restantes
            textoMision.text = "Busca y recoge las esmeraldas de color amarillo" +
                       "\n Restantes: " + numDeObjetivos; // Actualizar el texto de la misión con la nueva cantidad de objetivos restantes

            if (numDeObjetivos == 5) // Si la cantidad de objetivos restantes es igual a 5
            {
                textoMision.text = "Ups, Recogiste un objeto que Simon no pidió"; // Mostrar un mensaje indicando que se recogió un objeto incorrecto
                botonDeMision.SetActive(true); // Activar el botón de misión
                Time.timeScale = 0f; // Detener el tiempo del juego
            }
        }
    }
}
