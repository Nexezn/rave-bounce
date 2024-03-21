using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class item : MonoBehaviour
{
    [SerializeField] private GameObject detailMenu;
    public float risk = 0.0f;
    public float value = 0.0f;

    
    public void OpenDetailUI(){
        detailMenu.SetActive(true);
    }
    public void CloseDetailMenuUI(){
        detailMenu.SetActive(false);
    }
}
