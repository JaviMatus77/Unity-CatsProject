using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private MainControls _inputActions;
    private Vector2 _movement;
    public float speed;

    private void Awake()
    {
        _inputActions = new MainControls();
        
        // Suscribirse a los eventos de movimiento
        _inputActions.Player01.Move.performed += ctx => OnMove(ctx);
        _inputActions.Player01.Move.canceled += ctx => OnMove(ctx);
        
        _inputActions.Player02.Move.performed += ctx => OnMove(ctx);
        _inputActions.Player02.Move.canceled += ctx => OnMove(ctx);
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
        // Establece el vector de movimiento según el jugador
        if (context.action.name == "Move")
        {
            _movement = context.ReadValue<Vector2>();
        }
        else
        {
            _movement = Vector2.zero; // Detiene el movimiento si la acción se cancela
        }
    }

    private void Update()
    {
        // Usa el vector de movimiento (por ejemplo, mover el personaje)
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Lógica para mover el jugador
        transform.Translate(_movement * Time.deltaTime * speed);
    }
}
