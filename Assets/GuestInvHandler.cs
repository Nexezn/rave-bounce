using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestInvHandler : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GuestCheck gc;
    [SerializeField] Transform[] location;
    [SerializeField] GameObject[] locGO; 
    [SerializeField] private List<GameObject> itemlist;
    private GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnEnable(){
        itemlist = gc.GetItemList();

        for (int i = 0; i < 8; i++){
            temp = Instantiate(itemlist[i], location[i].position, location[i].rotation);
            locGO[i].GetComponent<Slot>().SetCurItem(temp.GetComponent<item>());
        }
    }

    void OnDisable(){
        GameObject[] go = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject target in go){
            GameObject.Destroy(target);
        }
    }
}
