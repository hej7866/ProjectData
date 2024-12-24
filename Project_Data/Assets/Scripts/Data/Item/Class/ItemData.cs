using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemName", menuName = "GameData/ItemData")]
public class ItemData : ScriptableObject
{
    public enum ItemType {A, B, C, D}

    public int id = -1;
    public ItemType type;
    public string Itemname = "이름";
    public string itemDesc = "아이템 설명";
    public Sprite itemIcon = null;
}
