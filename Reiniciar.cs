using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    // Script para reiniciar las escenas

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

    public void Simondice()
    {
        SceneManager.LoadScene("SimonDice"); // Cargar la escena "SimonDice"
    }

    public void Simondice1()
    {
        SceneManager.LoadScene("SimonDice 1"); // Cargar la escena "SimonDice 1"
    }

    public void Simondicelvl2()
    {
        SceneManager.LoadScene("SimonDicelvl2"); // Cargar la escena "SimonDicelvl2"
    }

    public void Simondice2()
    {
        SceneManager.LoadScene("SimonDicelvl2 1"); // Cargar la escena "SimonDicelvl2 1"
    }

    public void Simondicelvl3()
    {
        SceneManager.LoadScene("SimonDicelvl3"); // Cargar la escena "SimonDicelvl3"
    }

    public void Simondice3()
    {
        SceneManager.LoadScene("SimonDicelvl3 1"); // Cargar la escena "SimonDicelvl3 1"
    }

    public void Reiniciarlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Cargar la escena actual (reiniciar la escena)
    }
}
