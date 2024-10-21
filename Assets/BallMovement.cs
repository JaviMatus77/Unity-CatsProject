using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //public List<GameObject> jugadores;

    public Transform objetivo; // El objeto hacia el que se moverá
    public float velocidad = 5f; // La velocidad de movimiento

    void Update()
    {
        // Mueve el objeto hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
    }
}
