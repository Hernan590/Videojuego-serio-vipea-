using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Se instala la libreria "TMpro"

public class HUD1 : MonoBehaviour
{
    //Este script controla el HUD (interfaz de usuario) del juego y muestra los puntos totales malos en un componente TextMeshProUGUI.

    public GameManagerBad gameManagerBad; // Referencia al GameManagerBad
    public TextMeshProUGUI puntosmalos; // Referencia al componente TextMeshProUGUI para mostrar los puntos malos


    void Update()
    {
        puntosmalos.text = gameManagerBad.PuntosTotalesmalos.ToString(); // Actualizar el texto del componente con los puntos totales malos convertidos a cadena
    }
}
