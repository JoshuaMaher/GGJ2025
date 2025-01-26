using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{

    public ParticleSystem particle;
    public AudioSource source;
    public AudioClip splush;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if(other.gameObject.CompareTag("Boba")) 
        {
            source.PlayOneShot(splush);
            particle.Play();
        }
    }
}
