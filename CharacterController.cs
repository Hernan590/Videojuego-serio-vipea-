using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Este script se utiliza para el movimiento del personaje en la prueba "Simon dice"

    public float velocidad; // Velocidad de movimiento del personaje
    public float FuerzaSalto; // Fuerza aplicada al saltar
    public LayerMask capaSuelo; // Capa que representa el suelo
    public int saltosMaximos; // Número máximo de saltos

    private Rigidbody2D rigidbody; // Componente Rigibody para controlar las fisicas 
    private BoxCollider2D boxCollider; // Componente Boxcollider para controlar las colisiones del personaje
    private bool mirandoDerecha = true; // Indica si el personaje está mirando hacia la derecha
    private int saltosRestantes; // Número de saltos restantes
    private Animator animator;  // Componente Animator para controlar las animaciones

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();  // Obtener el componente Rigidbody2D del personaje
        boxCollider = GetComponent<BoxCollider2D>(); // Obtener el componente BoxCollider2D del personaje
        saltosRestantes = saltosMaximos; // Establecer los saltos restantes al máximo inicial
        animator = GetComponent<Animator>(); // Obtener el componente Animator del personaje
    }
    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento(); // Procesar el movimiento del personaje
        ProcesarSalto(); // Procesar el salto del personaje
    }

    bool EstaEnSuelo()
    {
        // Realizar un raycast hacia abajo para verificar si el personaje está en contacto con el suelo
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, capaSuelo);
        return raycastHit.collider != null; // Devolver true si el raycast chocó con algo (suelo), de lo contrario false
    }

    void ProcesarSalto()
    {
        if(EstaEnSuelo())
        {
            saltosRestantes = saltosMaximos; // Restablecer los saltos restantes al máximo si el personaje está en el suelo

        }

        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0)  // Verificar si se presionó la tecla de salto y aún quedan saltos restantes
        {
            saltosRestantes = saltosRestantes - 1; // Restar un salto de los saltos restantes
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0f); // Establecer la velocidad vertical a cero para evitar problemas con la física
            rigidbody.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse); // Aplicar una fuerza vertical hacia arriba para el salto
        }

    }

    void ProcesarMovimiento()
    {
        // Logica de Movimiento.
        float inputMovimiento = Input.GetAxis("Horizontal"); // Obtener el valor del eje horizontal para el movimiento

        if (inputMovimiento != 0f)
        {
            animator.SetBool("isRunning", true); // Establecer el parámetro "isRunning" en true en el Animator para reproducir la animación de correr

        }
        else
        {
            animator.SetBool("isRunning", false); // Establecer el parámetro "isRunning" en false en el Animator para detener la animación de correr

        }

        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y); // Establecer la velocidad horizontal del personaje

        GestionarOrientacion(inputMovimiento); // Gestionar la orientación del personaje según su movimiento
    }

    void GestionarOrientacion(float inputMovimiento)
    {
        // Si se cumple condicion
        if(mirandoDerecha == true && inputMovimiento < 0 || (mirandoDerecha == false && inputMovimiento > 0) )
        {

            // Ejecutar codigo de volteado
            mirandoDerecha = !mirandoDerecha; // Invertir el valor de mirandoDerecha para cambiar la orientación del personaje
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y); // Invertir la escala en el eje X para voltear el personaje
        }

    }
}
