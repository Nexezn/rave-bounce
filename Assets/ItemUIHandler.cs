using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackButtonPressed()
    {
        this.gameObject.SetActive(false);
    }
}
