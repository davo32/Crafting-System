using TMPro;
using UnityEngine;
namespace InventoryBackend
{
    public enum Quality
    {
        NONE,
        COMMON,
        RARE,
        EPIC,
        EXOTIC,
        MYTHIC
    }

    public class Inv_Item : DataObject
    {
        public Sprite itemSprite;
        public string ItemName;
        public int Quantity;
        public Quality quality;
        public bool Stackable;
        public Inv_Item() { }
        //Constructor - Default
        public Inv_Item(Sprite s, string name, int quantity, Quality q, bool stackable)
        {
            itemSprite = s;
            ItemName = name;
            Quantity = quantity;
            quality = q;
            Stackable = stackable;
        }

        //Copy Constructor
        public Inv_Item(Inv_Item copyData)
        {
            itemSprite = copyData.itemSprite;
            ItemName = copyData.ItemName;
            Quantity = copyData.Quantity;
            quality = copyData.quality;
            Stackable = copyData.Stackable;
        }

        public virtual void Use(TextMeshProUGUI text)
        {
            Debug.Log("[SYSTEM] - This is the Base Class for Items");
        }
    }
}
