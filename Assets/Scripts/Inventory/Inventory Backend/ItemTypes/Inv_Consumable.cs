
using TMPro;
using UnityEngine;

namespace InventoryBackend
{
    public class Inv_Consumable : Inv_Item
    {
        public int Amount;

        public Inv_Consumable() { }
        public Inv_Consumable(Sprite s, string name, int amount, int quantity, Quality q)
        {
            itemSprite = s;
            ItemName = name;
            Amount = amount;
            Quantity = quantity;
            quality = q;
        }
        public Inv_Consumable(Inv_Consumable copyData)
        {
            itemSprite = copyData.itemSprite;
            ItemName = copyData.ItemName;
            Amount = copyData.Amount;
            Quantity = copyData.Quantity;
            quality = copyData.quality;
        }

        public override void Use(TextMeshProUGUI text)
        {
            Debug.Log("[SYSTEM] - This is the Consumable Class for Items");
            text.text = $"{ItemName} has been used";
        }
    }
}
