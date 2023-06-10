using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBad : MonoBehaviour
{
    // Este script se utiliza para administrar puntos malos en lugar de puntos buenos

    // Propiedad para obtener los puntos totales malos
    public int PuntosTotalesmalos { get { return puntosTotalesmalos; } }
    private int puntosTotalesmalos; // Variable para almacenar los puntos totales malos

    // Método para sumar puntos malos
    public void SumarPuntosmalos(int puntosASumar)
    {
        puntosTotalesmalos += puntosASumar; // Incrementar los puntos totales malos
        Debug.Log(puntosTotalesmalos); // Imprimir los puntos totales malos en la consola
    }
}
