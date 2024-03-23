using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private LevelManager LM;
    [SerializeField] private Lock frontLock;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.GetComponent<Raver>() != null){
            LM.guestsChecked += 1;
            LM.totalMoney += other.GetComponent<Raver>().value;
            LM.totalRisk += other.GetComponent<Raver>().risk;
            GameObject.Destroy(other.gameObject);
            frontLock.Unlock();

        }
    }
}
