using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Este script implementa un administrador de juego b�sico que permite sumar puntos y realizar un seguimiento de los puntos totales.

    // Propiedad para obtener los puntos totales
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales; // Variable para almacenar los puntos totales

    // M�todo para sumar puntos
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar; // Incrementar los puntos totales
        Debug.Log(puntosTotales); // Imprimir los puntos totales en la consola
    }
}
