using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    //Este script muestra el cronometro del juego en la prueba "movimiento"

    public float contador; // Contador de tiempo
    public Text ContadorText; // Texto para mostrar el contador
    public GameObject anuncio; // GameObject para mostrar el anuncio
    public GameObject botonrepetir; // GameObject para mostrar el botón de repetir
    public int TiempotoText; // Tiempo convertido a entero para mostrar en el texto

    // Start is called before the first frame update
    void Start()
    {
        // Inicialización del temporizador y otros objetos relacionados
    }

    // Update is called once per frame
    void Update()
    {
        contador -= Time.deltaTime; // Restar tiempo al contador
        TiempotoText = (int)contador; // Convertir el tiempo a entero
        ContadorText.text = TiempotoText.ToString(); // Actualizar el texto con el tiempo restante

        if (contador <= 0)
        {
            anuncio.SetActive(true); // Mostrar el anuncio
            botonrepetir.SetActive(true); // Mostrar el botón de repetir
            Time.timeScale = 0f; // Pausar el juego
        }
    }
}
