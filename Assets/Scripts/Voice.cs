using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public AudioSource SignWitch;
    void Start()
    {
        SignWitch = GetComponent<AudioSource>();
    }
     
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WitchSign"))
        {
            SignWitch.Play();
            Destroy(other.gameObject);

        }
    }
}
