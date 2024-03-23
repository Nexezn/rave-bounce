using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if (other.GetComponent<Raver>() != null){
            Destroy(other.gameObject);
        }
    }
}
