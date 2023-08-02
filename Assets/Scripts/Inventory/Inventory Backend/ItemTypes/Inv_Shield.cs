using InventoryBackend;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inv_Shield : Inv_Item
{
    public int Defense;
    public Inv_Shield() { }

    public Inv_Shield(Sprite s, string name, int defense, int quantity, Quality q)
    { 
        itemSprite = s;
        ItemName = name;
        Defense = defense;
        Quantity = quantity;
        quality = q;
    }

    public Inv_Shield(Inv_Shield copyData)
    { 
        itemSprite = copyData.itemSprite;
        ItemName = copyData.ItemName;
        Defense = copyData.Defense;
        Quantity = copyData.Quantity;
        quality = copyData.quality;
    }

    public override void Use(TextMeshProUGUI text)
    {
        Debug.Log("[SYTSTEM] - This is the Shield Class for Items");
        text.text = $"{ItemName} has been Equipped";
    }
}
