using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [Header("Configuración de Salud")]
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Eventos")]
    public UnityEvent onHealthChanged;
    public UnityEvent onDeath;

    void Start()
    {
        currentHealth = maxHealth;
        onHealthChanged?.Invoke(); // Invoca el evento al iniciar
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Asegura que no baje de 0

        onHealthChanged?.Invoke(); // Invoca evento al recibir daño

        Debug.Log("currentHealth: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Asegura que no exceda el máximo

        onHealthChanged?.Invoke(); // Invoca evento al curarse
    }

    private void Die()
    {
        // Lógica de muerte
        Debug.Log("El jugador ha muerto.");
        onDeath?.Invoke(); // Invoca evento al morir
        // Aquí puedes desactivar el jugador, reproducir animaciones, etc.
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }
}
