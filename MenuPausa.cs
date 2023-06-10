using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    //Este script controla el men� de pausa en el juego

    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;

    private void Update()
    {
        // Verificar si se presiona la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si el juego est� pausado, se reanuda, de lo contrario se pausa
            if (juegoPausado)
                {
                    Reanudar();
                }
                else
                {
                    Pausa();
                }
        }
    }

    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f; // Pausar el tiempo del juego
        botonPausa.SetActive(false); // Desactivar el bot�n de pausa
        menuPausa.SetActive(true); // Mostrar el men� de pausa
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        botonPausa.SetActive(true); // Activar el bot�n de pausa
        menuPausa.SetActive(false); // Ocultar el men� de pausa
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f; // Restablecer el tiempo del juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Cargar la escena actual
    }

    public void Iralmenuprincipal()
    {
        SceneManager.LoadScene("inicio"); // Cargar la escena "inicio" (men� principal)
        Time.timeScale = 1f; // Restablecer el tiempo del juego
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando juego");
        Application.Quit(); // Cerrar la aplicaci�n
    }
}
