using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transport : MonoBehaviour
{
    Vector3 playerPosition;
    Vector3 newPosition = new Vector3(4f , 7.5f , 60.3f);
    public InputActionReference action;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //
        action.action.performed += (ctx) =>
        {
            
            //string playerName = "PlayerRig";//GameObject playerParent = GameObject.Find("PlayerRig");
           // GameObject player = gameObject.transform.Find(playerName);
            player = transform.GetChild(0).gameObject;
            //playerPosition = player.transform.position;
            playerPosition = transform.position;
            player.transform.position = newPosition;
            newPosition = playerPosition;

                 
        };
    }
}
