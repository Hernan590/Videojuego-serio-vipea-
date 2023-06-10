using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logicaesferas : MonoBehaviour
{
    //Este script controla la lógica de las esferas en el juego

    public int numDeObjetivos; // Número de objetivos que deben ser recogidos
    public TextMeshProUGUI textoMision; // Referencia al texto de la misión
    public GameObject botonDeMision; // Referencia al botón de misión

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f; // Restablecer el tiempo a su valor normal
        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length; // Obtener el número de objetivos en el inicio del juego
        textoMision.text = "Simon dice: Busca y recoge las esferas rojas y amarillas." +
                           "\nRestantes: " + numDeObjetivos; // Actualizar el texto de la misión con el número de objetivos restantes
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
            textoMision.text = "Simon dice: Busca y recoge las esferas rojas y amarillas." +
                               "\nRestantes: " + numDeObjetivos; // Actualizar el texto de la misión con el número de objetivos restantes

            if (numDeObjetivos <= 0) // Si no quedan objetivos restantes
            {
                textoMision.text = "¡Bien hecho! Terminaste todas las peticiones de Simon, ahora él está feliz. Haz clic en terminar";
                botonDeMision.SetActive(true); // Mostrar el botón de misión completada
                Time.timeScale = 0f; // Detener el tiempo (pausar el juego)
            }
        }
    }
}