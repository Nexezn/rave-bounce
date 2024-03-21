using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemListSO")]
public class ItemsList : ScriptableObject
{
    public GameObject[] items;
}
