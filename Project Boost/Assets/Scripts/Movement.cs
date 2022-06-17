using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  [SerializeField] float mainThrust = 1000f;
  [SerializeField] float rotationThrust = 100f;
  [SerializeField] AudioClip mainEngine;
  [SerializeField] ParticleSystem thrustLeftParticles;
   [SerializeField] ParticleSystem thrustRightParticles;
   [SerializeField] ParticleSystem jetParticles;
  Rigidbody rb;
  AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      ProcessThrust();
      ProcessRotation();
    }

    void ProcessThrust()
    {
      if (Input.GetKey(KeyCode.Space))
       {
           rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
           if (!audioSource.isPlaying)
           {
              audioSource.PlayOneShot(mainEngine);
              jetParticles.Play();
           }
           
       }
       else
       {
        audioSource.Stop();
        jetParticles.Stop();
       }
    }
    void ProcessRotation()
    {
      if (Input.GetKey(KeyCode.A))
        {
         ApplyRotation(rotationThrust);
         thrustRightParticles.Play();
         
        }
        else if (Input.GetKey(KeyCode.D))
       {
         ApplyRotation(-rotationThrust);
         thrustLeftParticles.Play();
         
       }
       else
       {
        thrustRightParticles.Stop();
        thrustLeftParticles.Stop();
       }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; //freezing rotatioan
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; //unfreezing rotatioan
       }
}
