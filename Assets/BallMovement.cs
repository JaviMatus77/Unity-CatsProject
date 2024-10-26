using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public List<GameObject> players;
    private int currentIndex = 0;

    [Header("Movement Settings")]
    public float speed = 5f;
    public float speedIncreaseAmount = 0.5f; // Amount to increase speed
    public int damageAmount = 20;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        players = GameManager.instance.players;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (players.Count == 0) return;

        MoveTowardsCurrentPlayer();
        CheckPlayerReached();
    }

    private void MoveTowardsCurrentPlayer()
    {
        Transform target = players[currentIndex].transform;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void CheckPlayerReached()
    {
        Transform target = players[currentIndex].transform;
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentIndex = (currentIndex + 1) % players.Count;
            IncreaseSpeed();
            UpdateColorBasedOnSpeed();
        }
    }
    public void ChangeTarget()
    {
        currentIndex = (currentIndex + 1) % players.Count;
        IncreaseSpeed();
        UpdateColorBasedOnSpeed();
    }

    private void IncreaseSpeed()
    {
        speed += speedIncreaseAmount;
    }

    private void UpdateColorBasedOnSpeed()
    {
        if (speed >= 20)
            spriteRenderer.color = Color.red;
        else if (speed >= 10)
            spriteRenderer.color = Color.yellow;
        else if (speed >= 5)
            spriteRenderer.color = Color.green;
        else
            spriteRenderer.color = Color.white; // Reset to default if under 5
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth?.TakeDamage(damageAmount);
        }
    }
}
