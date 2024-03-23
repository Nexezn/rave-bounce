using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEnd : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Lock thisLock;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other){
        thisLock.LockSpot();
    }
    private void OnTriggerExit2D(Collider2D other){
        thisLock.Unlock();
    }
}
