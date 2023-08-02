using TMPro;
using UnityEngine;

namespace InventoryBackend
{
    public class Inv_Weapon : Inv_Item
    {
       public int Damage;

       public Inv_Weapon() { }
        public Inv_Weapon(Sprite s, string name, int damage, int quantity, Quality q)
        {
            itemSprite = s;
            ItemName = name;
            Damage = damage;
            Quantity = quantity;
            quality = q;
        }
        public Inv_Weapon(Inv_Weapon copyData)
        {
            itemSprite = copyData.itemSprite;
            ItemName = copyData.ItemName;
            Damage = copyData.Damage;
            Quantity = copyData.Quantity;
            quality = copyData.quality;
        }

        public override void Use(TextMeshProUGUI text)
        {
            Debug.Log("[SYSTEM] - This is the Weapon Class for Items");
            text.text = $"{ItemName} has been Equipped";
        }

    }
}
