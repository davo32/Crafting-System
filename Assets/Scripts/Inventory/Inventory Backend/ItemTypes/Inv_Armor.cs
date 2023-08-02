using TMPro;
using UnityEngine;

namespace InventoryBackend
{
    public class Inv_Armor : Inv_Item
    {
        public int Defense;

        public Inv_Armor(Sprite s, string name, int defense, int quantity, Quality q)
        {
            itemSprite = s;
            ItemName = name;
            Defense = defense;
            Quantity = quantity;
            quality = q;
        }

        public Inv_Armor(Inv_Armor copyData)
        {
            itemSprite = copyData.itemSprite;
            ItemName = copyData.ItemName;
            Defense = copyData.Defense;
            Quantity = copyData.Quantity;
            quality = copyData.quality;
        }

        public override void Use(TextMeshProUGUI text)
        {
            Debug.Log("[SYSTEM] - This is the Armor Class for Items");
            text.text = $"{ItemName} has been Equipped";
        }
    }
}
