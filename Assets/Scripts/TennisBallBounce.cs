using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBallBounce : MonoBehaviour
{
    
    // Start is called before the first frame update
    public AudioClip ballbounce;
    AudioSource audioSource;
    Rigidbody rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(ballbounce, 0.7F * rb.velocity.magnitude);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
