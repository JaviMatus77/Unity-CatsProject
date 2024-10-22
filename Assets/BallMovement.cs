using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public List<GameObject> players;
    private int currentIndex = 0;

    public float speed = 5f; // La velocidad de movimiento
    public int damageAmount = 20;

    private void Start()
    {
        this.players = GameManager.instance.players;
    }

    void Update()
    {
        // Check if there are players in the list
        if (players.Count == 0) return;

        Transform objetivo = players[currentIndex].transform;

        // Move the object towards the target
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, speed * Time.deltaTime);

        // Check if the ball has reached the target
        if (Vector3.Distance(transform.position, objetivo.position) < 0.1f)
        {
            // Move to the next player
            currentIndex = (currentIndex + 1) % players.Count;
            speed += 1;

            Debug.Log("SpeedUp!");

            if (speed >= 5 && speed < 10) this.GetComponent<SpriteRenderer>().color = Color.green;
            if (speed >= 10 && speed < 20) this.GetComponent<SpriteRenderer>().color = Color.yellow;
            if (speed >= 20) this.GetComponent<SpriteRenderer>().color = Color.red;
        }        
    }

    //tenemos dos logicas para cuando choca
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");

        // Verifica si el objeto colisionado tiene el componente PlayerHealth
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log("¡Jugador golpeado!");
            }
        }
    }

}
