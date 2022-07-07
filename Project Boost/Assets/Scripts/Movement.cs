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
            StartThrusting();

        }
        else
        {
            StopThrusting();
        }
    }
    void ProcessRotation()
    {
      if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight();

        }
        else
        {
            StopRotation();
        }
    }

    void StartThrusting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!jetParticles.isPlaying)
        {
            jetParticles.Play();
        }
    }
   void StopThrusting()
    {
        audioSource.Stop();
        jetParticles.Stop();
    }

    

    void StopRotation()
    {
        thrustRightParticles.Stop();
        thrustLeftParticles.Stop();
    }

    void RotateRight()
    {
        ApplyRotation(-rotationThrust);
        if (!thrustLeftParticles.isPlaying)
        {
            thrustLeftParticles.Play();

        }
    }

    void RotateLeft()
    {
        ApplyRotation(rotationThrust);
        if (!thrustRightParticles.isPlaying)
        {
            thrustRightParticles.Play();
        }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; //freezing rotatioan
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; //unfreezing rotatioan
       }
}
