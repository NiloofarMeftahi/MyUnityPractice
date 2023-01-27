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
    // [SerializeField] InputAction lightSwitch;
    void Start()
    {
        changeLight = GetComponent<Light>();
        action.action.Enable();
        action1.action.Enable();
       
    }
    // private void OnEnable() 
    // {   
    //     lightSwitch.Enable();
        
    // }
    // private void  OnDisable()  
    // {   
    //     lightSwitch.Disable();
        
    // }

    // Update is called once per frame
    void Update()
    {
        // float pinkLight = lightSwitch.ReadValue<Vector2>().x;
        // float yellowLight = lightSwitch.ReadValue<Vector2>().y;
        // if (pinkLight == 1)
        //     changeLight.color = newColor;
        // if (yellowLight == 1)
        // changeLight.color = newColor1;

        action.action.performed += (ctx) =>
        {
            changeLight.color = newColor;
                 
        };
         action1.action.performed += (ctx) =>
        {
            changeLight.color = newColor1;
                 
        };
    }
}
