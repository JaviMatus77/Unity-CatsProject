using UnityEngine;
using UnityEngine.InputSystem;

public class AudioInitializer : MonoBehaviour
{
    //ESTE SCRIPT CAPTURA EVENTOS Y LES ASIGNA UN EFECTO DE SONIDO
    //ESTE SCRIPT HABLA CON AudioManager.cs
    //LOS EVENTOS PUEDEN SER
    //Acciones del Jugador:

    //Saltar
    //Disparar
    //Recibir da�o
    //Interactuar con objetos
    //Usar habilidades especiales
    //Correr
    //Eventos del Entorno:

    //Abrir o cerrar puertas
    //Caer objetos
    //Cambios de clima(lluvia, tormenta)
    //Colisiones con el entorno(choques, explosiones)
    //Interacciones con Enemigos:

    //Enemigos atacando
    //Enemigos siendo da�ados
    //Enemigos derrotados
    //Enemigos apareciendo
    //Eventos de UI:

    //Abrir/cerrar men�s
    //Confirmar selecciones
    //Navegar entre opciones
    //Eventos de Juego:

    //Iniciar una misi�n
    //Completar una misi�n
    //Cambios de nivel o zona
    //Recolecci�n de �tems
    //Eventos Ambientales:

    //Sonidos de fondo que cambian seg�n el �rea
    //Eventos de naturaleza(rugidos de animales, sonidos de agua)
    //Eventos de Jugabilidad:

    //Temporizadores(por ejemplo, al vencer el tiempo)
    //Cambios en la salud del jugador o de los enemigos
    //Activaci�n de trampas

    private MainControls _inputActions;
    private PlayerHealth[] playerHealths;

    private void Awake()
    {
        _inputActions = new MainControls();

        // Suscribirse a los eventos de movimiento

        _inputActions.Player01.Move.performed += ctx => OnMove(ctx);
        _inputActions.Player01.Move.canceled += ctx => OnMove(ctx);
        _inputActions.Player01.Interact.performed += ctx => OnInteract(ctx);

        _inputActions.Player02.Move.performed += ctx => OnMove(ctx);
        _inputActions.Player02.Move.canceled += ctx => OnMove(ctx);
        _inputActions.Player02.Interact.performed += ctx => OnInteract(ctx);

        playerHealths = FindObjectsOfType<PlayerHealth>();

        foreach (var playerHealth in playerHealths)
        {
            playerHealth.onHealthChanged.AddListener(OnHealthChanged);
            playerHealth.onDeath.AddListener(OnPlayerDeath);
        }
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        //SONIDO MOVERSE
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        //SONIDO DISPARO
        print("INteractuandooo!! sonidooo eeee");
        AudioManager.Instance.PlaySound("Special & Powerup 34");
    }

    private void OnHealthChanged()
    {
        // Aqu� puedes reproducir el sonido que quieras al cambiar la salud
        AudioManager.Instance.PlaySound("Buzz Error 09");
    }

    private void OnPlayerDeath()
    {
        // Aqu� puedes reproducir el sonido que quieras al morir
        AudioManager.Instance.PlaySound("Special & Powerup 43");
    }
}

