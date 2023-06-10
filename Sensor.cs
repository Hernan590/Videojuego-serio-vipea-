using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Sensor : MonoBehaviour
{
    //Este script controla el movimiento del personaje mediante el sensor inercial

    public float movementSpeed = 5f; // Velocidad de movimiento
    public GameObject Personajetopdown; // Referencia al objeto del personaje

    SerialPort sp = new SerialPort("COM5", 9600); // Puerto serial para la comunicación

    // Start is called before the first frame update
    void Start()
    {
        sp.Open(); // Abrir el puerto serial
        sp.ReadTimeout = 1; // Tiempo de espera para la lectura
    }

    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen) // Verificar si el puerto serial está abierto
        {
            try
            {
                string data = sp.ReadLine(); // Leer los datos recibidos
                Debug.Log(data); // Mostrar los datos en la consola (para propósitos de depuración)
                if (data.Equals("arriba")) // Si los datos recibidos son "arriba"
                {
                    Personajetopdown.transform.Translate(Vector3.up * movementSpeed * Time.deltaTime); // Mover el personaje hacia la izquierda
                }
                if (data.Equals("abajo")) // Si los datos recibidos son "abajo"
                {
                    Personajetopdown.transform.Translate(Vector3.down * movementSpeed * Time.deltaTime); // Mover el personaje hacia la derecha
                }
                if (data.Equals("izquierda")) // Si los datos recibidos son "izquierda"
                {
                    Personajetopdown.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime); // Mover el personaje hacia arriba
                }
                if (data.Equals("derecha")) // Si los datos recibidos son "derecha"
                {
                    Personajetopdown.transform.Translate(Vector3.right * movementSpeed * Time.deltaTime); // Mover el personaje hacia abajo
                }
            }
            catch (System.Exception)
            {
                // Manejar excepciones de lectura de datos
            }
        }
    }

    void OnApplicationQuit()
    {
        sp.Close(); // Cerrar el puerto serial al salir de la aplicación
    }
}
