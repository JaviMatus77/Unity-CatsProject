using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public AudioAnalyzer audioAnalyzer;
    public int bandIndex = 0; // Índice de la banda de frecuencia a utilizar
    public float rotationSpeedMultiplier = 100f;
    private Vector3 rotationAxis = Vector3.forward; // Puedes cambiar el eje de rotación

    void Start()
    {
        audioAnalyzer = FindObjectOfType<AudioAnalyzer>();
    }

    void Update()
    {
        float intensity = audioAnalyzer.frequencyBands[bandIndex];
        transform.Rotate(rotationAxis, intensity * rotationSpeedMultiplier * Time.deltaTime);
    }
}
