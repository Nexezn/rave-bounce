using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    public item currItem;
    private Color startColor;
    // Start is called before the first frame update
    void Start()
    {
        //startColor = sr.color;
    }

    private void OnMouseEnter(){
       // sr.color = hoverColor;
    }

    private void OnMouseExit(){
       // sr.color = startColor;
    }

    public void SetCurItem(item i){
        currItem = i;
    }

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData){
        if (eventData.button == PointerEventData.InputButton.Left){
            currItem.OpenDetailUI();
        }
    }
}
