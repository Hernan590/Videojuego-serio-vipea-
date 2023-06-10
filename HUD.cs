using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Se instala la libreria "TMpro"

public class HUD : MonoBehaviour
{
    //Este script controla el HUD (interfaz de usuario) del juego y muestra los puntos totales en un componente TextMeshProUGUI.

    public GameManager gameManager; // Referencia al GameManager
    public TextMeshProUGUI puntos; // Referencia al componente TextMeshProUGUI para mostrar los puntos


    void Update()
    {
        puntos.text = gameManager.PuntosTotales.ToString(); // Actualizar el texto del componente con los puntos totales convertidos a cadena
    }
}
