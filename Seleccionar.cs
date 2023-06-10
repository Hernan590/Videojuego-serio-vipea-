using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seleccionar : MonoBehaviour
{
    //Script para cargar las distintas escenas de inicio del juego

    // Start is called before the first frame update
    void Start()
    {
        // No hay implementación en este caso
    }

    // Update is called once per frame
    void Update()
    {
        // No hay implementación en este caso
    }

    public void SimonDice()
    {
        SceneManager.LoadScene("SimonDice"); // Cargar la escena "SimonDice"
    }

    public void Movimiento()
    {
        SceneManager.LoadScene("Movimiento"); // Cargar la escena "Movimiento"
    }

    public void Volver()
    {
        SceneManager.LoadScene("Inicio"); // Cargar la escena "Inicio"
    }

    public void Volvereleccion()
    {
        SceneManager.LoadScene("Eleccion"); // Cargar la escena "Eleccion"
    }

    public void eleccionmovimiento()
    {
        SceneManager.LoadScene("Eleccionmovimiento"); // Cargar la escena "Eleccionmovimiento"
    }

    public void instruccionteclado1()
    {
        SceneManager.LoadScene("Instrtecladomovimiento1"); // Cargar la escena "Instrtecladomovimiento1"
    }

    public void instruccionteclado2()
    {
        SceneManager.LoadScene("Instrtecladomovimiento2"); // Cargar la escena "Instrtecladomovimiento2"
    }

    public void instruccion()
    {
        SceneManager.LoadScene("InstruccionSimon1"); // Cargar la escena "InstruccionSimon1"
    }

    public void instruccion2()
    {
        SceneManager.LoadScene("InstruccionSimon2"); // Cargar la escena "InstruccionSimon2"
    }

    public void movimientosensor()
    {
        SceneManager.LoadScene("Consensor"); // Cargar la escena "Consensor"
    }
}
