using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestCheck : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject checkGuestTooltip;
    [SerializeField] private GameObject guestMenu;
    
    [Header("Attributes")]
    public bool inspectKey = false;
    private Collider2D currentGuest;
    private List<GameObject> tempList;
    private string tempConvo;
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
            currentGuest = other;
            Debug.Log("GUEST AT FOH.");
            checkGuestTooltip.SetActive(true);
            //grab 
            tempList = other.GetComponent<Raver>().GetGOList();
            tempConvo = other.GetComponent<Raver>().conversation;
        }
    }

    private IEnumerator CheckKeyRoutine(){
        yield return new WaitUntil(() => inspectKey == true);
    }

    public void CheckGuest(){
        //Retrieve Guest stats and object and populate menu with them.

        //Show menu.
        checkGuestTooltip.SetActive(false);
        guestMenu.SetActive(true);
    }

    public void LetIn(){
        guestMenu.SetActive(false);
        currentGuest.GetComponent<Raver>().updateGreenLight(true);
    }

    public void Kick(){
        guestMenu.SetActive(false);
        currentGuest.GetComponent<Raver>().updateRedLight(true);
    }

    public List<GameObject> GetItemList(){
        return tempList;
    }

    public string GetConvo(){
        return tempConvo;
    }
}
