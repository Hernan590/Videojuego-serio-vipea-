using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controladortopdown : MonoBehaviour
{
    // Este script controla el movimiento del personaje en la prueba "Movimiento"

    [SerializeField] private float velocidadMovimiento; // Velocidad de movimiento del personaje

    [SerializeField] private Vector2 direccion; // Dirección de movimiento del personaje

    private Rigidbody2D rb2D; // Referencia al componente Rigidbody2D del personaje
    private float movimientoX;  // Valor de movimiento en el eje X
    private float movimientoY; // Valor de movimiento en el eje Y
    private Animator animator; // Referencia al componente Animator del personaje


    private void Start(){

        // Aquí se ejecuta el código al inicio del juego

        animator = GetComponent<Animator>(); // Obtener el componente Animator del personaje
        rb2D = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D del personaje
    }

    private void Update(){

        // Aquí se ejecuta el código en cada fotograma del juego

        // Obtener los valores de entrada de movimiento en los ejes X e Y
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");

        // Actualizar los parámetros del Animator para controlar la animación de movimiento
        animator.SetFloat("MovimientoX", movimientoX);
        animator.SetFloat("MovimientoY", movimientoY);

        if ( movimientoX != 0 || movimientoY != 0) {
            // Guardar la última dirección de movimiento para mantener la orientación del personaje
            animator.SetFloat("UltimoX", movimientoX);
            animator.SetFloat("UltimoY", movimientoY);
        }
        direccion = new Vector2(movimientoX, movimientoY).normalized;  // Normalizar la dirección de movimiento
    }

    private void FixedUpdate(){

        // Mover el personaje utilizando el componente Rigidbody2D y la dirección de movimiento
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }

}
