using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public PlayerHealth playerHealth; // Referencia al script de salud del jugador
    public Image healthBarImage; // Referencia a la imagen de la barra de salud

    private void Start()
    {
        if (playerHealth != null)
        {
            playerHealth.onHealthChanged.AddListener(UpdateHealthBar);
            UpdateHealthBar(); // Actualiza la barra de salud al inicio
        }
    }

    private void UpdateHealthBar()
    {        
        if (playerHealth != null)
        {
            float healthPercentage = (float)playerHealth.GetCurrentHealth() / playerHealth.GetMaxHealth();
            healthBarImage.fillAmount = healthPercentage; // Actualiza la barra de salud

            print("actualizando Vida:" + healthPercentage);
        }
    }

    private void OnDestroy()
    {
        if (playerHealth != null)
        {
            playerHealth.onHealthChanged.RemoveListener(UpdateHealthBar); // Limpia el listener al destruir
        }
    }
}
