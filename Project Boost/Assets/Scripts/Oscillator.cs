using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startigPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor;
    [SerializeField] float period = 2f;

    void Start()
    {
       startigPosition = transform.position; 
      // Debug.Log(startigPosition);
    }

    void Update()
    {
       if ( period <= Mathf.Epsilon) { return; }
       float cycle = Time.time / period; //growing over time
       const float tau = Mathf.PI * 3;
       float rawSinWave = Mathf.Sin(cycle * tau); // going from -1 to 1
       movementFactor = (rawSinWave + 1f) / 2f; // recalculate to 0 to 1
       Vector3 offset = movementVector * movementFactor;
       transform.position = startigPosition + offset; 
    }
}
