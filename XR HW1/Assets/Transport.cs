using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transport : MonoBehaviour
{
    Vector3 playerPosition;
    Vector3 newPosition = new Vector3(0.1700001f , 4.2f , 60.3f);
    public GameObject player;
    bool turn;
    void Start()
    {
        turn = true;
    }

    void Update()
    {
       
        GameObject player = GameObject.Find("PlayerRig");
        playerPosition = player.transform.position;
        if (Input.GetButtonDown("RightContorllerB"))
        {
            player.transform.position = newPosition;
            if (turn)
                player.transform.rotation = Quaternion.Euler(new Vector3(180, 0, 180));
            else
                 player.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            turn = !turn;
            Debug.Log(turn);
            newPosition = playerPosition;
        }
    
            
    }
    
}
