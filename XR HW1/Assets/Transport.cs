using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transport : MonoBehaviour
{
    Vector3 playerPosition;
    Vector3 newPosition = new Vector3(4f , 7.5f , 60.3f);
    public GameObject player;
    // [SerializeField] InputAction lightSwitch;
    void Start()
    {
        
    }

    void Update()
    {
       
            GameObject player = GameObject.Find("PlayerRig");
            playerPosition = player.transform.position;
            if (Input.GetButtonDown("OculusKey"))
            {
            player.transform.position = newPosition;//
            newPosition = playerPosition;
            }
    
            
    }
    
}
