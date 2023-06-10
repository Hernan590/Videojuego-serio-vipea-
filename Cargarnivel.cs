using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Se instala la libreria SceneManagement

public class Cargarnivel : MonoBehaviour
{
    // Este script se utiliza para cargar diferentes niveles o escenas del juego

    void Start()
    {
        // Aqu� se ejecuta el c�digo al inicio del juego
    }

    void Update()
    {
        // Aqu� se ejecuta el c�digo en cada fotograma del juego
    }

    // M�todo para cargar la escena "Nodice"
    public void Nodice()
    {
        SceneManager.LoadScene("Nodice");
    }

    // M�todo para cargar la escena "Nodice2"
    public void Nodice2()
    {
        SceneManager.LoadScene("Nodice2");
    }

    // M�todo para cargar la escena "SimonDicelvl2"
    public void Simondice2()
    {
        SceneManager.LoadScene("SimonDicelvl2");
    }

    // M�todo para cargar la escena "SimonDicelvl3"
    public void Simondice3()
    {
        SceneManager.LoadScene("SimonDicelvl3");
    }

    // M�todo para cargar la escena "Movimientolvl2"
    public void Movimiento2()
    {
        SceneManager.LoadScene("Movimientolvl2");
    }

    // M�todo para cargar la escena "Consensor2"
    public void sensor2()
    {
        SceneManager.LoadScene("Consensor2");
    }

    // M�todo para cargar la escena "Eleccion"
    public void Finprueba() 
    {
        SceneManager.LoadScene("Eleccion");
    }

    // M�todo para reiniciar el nivel actual
    public void Reiniciarlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
