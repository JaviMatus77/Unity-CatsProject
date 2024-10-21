using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatDetection : MonoBehaviour
{
    public float bpm = 120; // Beats per minute
    private float beatInterval;
    private float nextBeatTime;

    public GameObject beatPrefab; // Renamed for clarity

    void Start() {
        beatInterval = 60f / bpm; // Calculate the interval between beats
        nextBeatTime = Time.time + beatInterval; // Initialize the next beat time
    }

    void Update() {
        if (Time.time >= nextBeatTime) {
            Debug.Log("Beat detected at: " + Time.time);
            nextBeatTime += beatInterval; // Calculate the next beat

            Instantiate(beatPrefab, transform.position, Quaternion.identity); // Instantiate the prefab at the object's position
        }
    }
}
