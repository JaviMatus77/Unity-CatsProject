using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatDetection : MonoBehaviour
{
    public float bpm = 120; // Beats per minute
    private float beatInterval;
    private float nextBeatTime;

    void Start() {
        beatInterval = 60f / bpm; // Calculate the interval between beats
        nextBeatTime = Time.time + beatInterval; // Initialize the next beat time
    }

    void Update() {
        if (Time.time >= nextBeatTime) {
            //Debug.Log("Beat detected at: " + Time.time);
            nextBeatTime += beatInterval;
            testing();
        }
    }

    //TESTING

    public GameObject beatPrefab;
    public Animator animator;
    public void testing()
    {
        //Instantiate(beatPrefab, this.transform.position, Quaternion.identity);

        animator = beatPrefab.GetComponent<Animator>();
        animator.Play(animator.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, 0f);
    }
}
