using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [Header("Attribute")]
    public bool locked = false;

    public void LockSpot(){
        locked = true;
    }

    public void Unlock(){
        locked = false;
    }
}
