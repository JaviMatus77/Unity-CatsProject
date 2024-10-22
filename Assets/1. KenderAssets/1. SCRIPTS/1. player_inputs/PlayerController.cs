using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private MainControls _inputActions;
    private Vector2 _movement;
    public float speed;

    public bool isPlayer01;
    public bool isPlayer02;

    private void Awake()
    {
        _inputActions = new MainControls();
        
        // Suscribirse a los eventos de movimiento

        if(isPlayer01){
            _inputActions.Player01.Move.performed += ctx => OnMove(ctx);
            _inputActions.Player01.Move.canceled += ctx => OnMove(ctx);

            _inputActions.Player01.Interact.performed += ctx => OnInteract(ctx);
        }
        else if(isPlayer02){
            _inputActions.Player02.Move.performed += ctx => OnMove(ctx);
            _inputActions.Player02.Move.canceled += ctx => OnMove(ctx);
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

    private void OnInteract(InputAction.CallbackContext context)
    {
        print("wena mis panitas");
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
