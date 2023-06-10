using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este script controla el men� principal del juego

    //Pasar a la siguiente pantalla
    public void Seleccionar()
    {
        SceneManager.LoadScene("Eleccion"); // Cargar la escena "Eleccion"
    }

    //Cerrar la aplicaci�n
    public void Salir()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit(); // Cerrar la aplicaci�n
    }
}
