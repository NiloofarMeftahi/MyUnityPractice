using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class LightSwitch : MonoBehaviour
{
    public Light changeLight;
    Color newColor = new Color(6f, 0.2f, 0.5f, 0.3f);
    Color newColor1 = new Color(30f, 10f, 1f, 1f);
    public InputActionReference action;
    public InputActionReference action1;
    void Start()
    {
        changeLight = GetComponent<Light>();
        action.action.Enable();
        action1.action.Enable();
       
    }
   

   
    void Update()
    {

        if (Input.GetButtonDown("LeftContollerX"))
            changeLight.color = newColor;
        if (Input.GetButtonDown("LeftContollerY"))
            changeLight.color = newColor1;

    }
}
