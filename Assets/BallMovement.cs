using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public List<GameObject> players;
    private int currentIndex = 0;

    public float speed = 5f; // La velocidad de movimiento

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

            if(speed > 10) this.GetComponent<SpriteRenderer>().color = Color.yellow;
            if(speed > 20) this.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
