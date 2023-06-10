using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaMeta : MonoBehaviour
{
    // Este script controla la lógica de alcanzar la bandera en el juego

    public int numDeObjetivos; // Número de objetivos que deben ser alcanzados
    public TextMeshProUGUI textoMision; // Referencia al texto de la misión
    public GameObject botonDeMision; // Referencia al botón de la misión

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        numDeObjetivos = GameObject.FindGameObjectsWithTag("bandera").Length; // Obtener el número de objetivos en el inicio del juego
        textoMision.text = "Llega a la bandera antes de que se termine el tiempo."; // Actualizar el texto de la misión
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bandera") // Comprobar si el objeto que colisionó tiene la etiqueta "bandera"
        {
            Destroy(col.transform.parent.gameObject); // Destruir el padre del objeto colisionado (la bandera)
            numDeObjetivos--; // Disminuir el número de objetivos restantes
            textoMision.text = "Llega a la bandera antes de que se termine el tiempo."; // Actualizar el texto de la misión
            if (numDeObjetivos <= 0) // Si no quedan objetivos restantes
            {
                textoMision.text = " Bien hecho, llegaste."; // Actualizar el texto de la misión
                botonDeMision.SetActive(true); // Activar el botón de la misión
                Time.timeScale = 0f; // Detener el tiempo (pausar el juego)
            }
        }
    }
}
