using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    public bool locked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LockSpot(){
        locked = true;
    }

    public void Unlock(){
        locked = false;
    }
}
