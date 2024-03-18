using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestCheck : MonoBehaviour
{
    [SerializeField] private GameObject checkGuestTooltip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.GetComponent<Raver>() != null){
            Debug.Log("GUEST AT FOH.");
            checkGuestTooltip.SetActive(true);

            //Create check guest function call here and return decision.
            //Use this code to provide decision.
            other.GetComponent<Raver>().updateRedLight(true);
        }
    }

    public void LetIn(){
        
    }
}
