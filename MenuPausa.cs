using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    //Este script controla el menú de pausa en el juego

    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;

    private void Update()
    {
        // Verificar si se presiona la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si el juego está pausado, se reanuda, de lo contrario se pausa
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
        botonPausa.SetActive(false); // Desactivar el botón de pausa
        menuPausa.SetActive(true); // Mostrar el menú de pausa
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        botonPausa.SetActive(true); // Activar el botón de pausa
        menuPausa.SetActive(false); // Ocultar el menú de pausa
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f; // Restablecer el tiempo del juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Cargar la escena actual
    }

    public void Iralmenuprincipal()
    {
        SceneManager.LoadScene("inicio"); // Cargar la escena "inicio" (menú principal)
        Time.timeScale = 1f; // Restablecer el tiempo del juego
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando juego");
        Application.Quit(); // Cerrar la aplicación
    }
}
