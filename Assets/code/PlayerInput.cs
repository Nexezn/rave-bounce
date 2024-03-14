using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    [Header("Attributes")]
    public  bool keyUp = false;
    public  bool keyDown = false;
    public  bool keyLeft = false;
    public  bool keyRight = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
            keyUp = true;
        }
        else{
            keyUp = false;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
            keyDown = true;
        }
        else{
            keyDown = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            keyLeft = true;
        }
        else{
            keyLeft = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            keyRight = true;
        }
        else{
            keyRight = false;
        }
    }
}
