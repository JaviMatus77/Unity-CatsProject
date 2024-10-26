using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject hitbox; // Asigna tu objeto hitbox en el Inspector

    public void PerformAttack()
    {
        hitbox.SetActive(true); // Activa el hitbox
        Invoke("DeactivateHitbox", 0.5f); // Llama a DeactivateHitbox después de 0.5 segundos
    }

    private void DeactivateHitbox()
    {
        hitbox.SetActive(false); // Desactiva el hitbox
    }
}


