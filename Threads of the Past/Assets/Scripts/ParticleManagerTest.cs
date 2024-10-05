using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParticleManagerTest : MonoBehaviour
{
    private ParticleSystem trailParticles;
   
    // Start is called before the first frame update
    void Start()
    {
        trailParticles = GetComponentInChildren<ParticleSystem>();

        trailParticles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleTrail(InputAction.CallbackContext context)
    {
        if(!trailParticles.isPlaying)
        {
            trailParticles.Play();
        }
    }
}
