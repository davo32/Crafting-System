using System.Collections.Generic;
using UnityEngine;
namespace InventoryBackend
{
    public struct InventoryStruct
    {
        private List<Inv_Item> InventoryItems;
        private int maxInventorySize;
        private int stackLimit;


        public InventoryStruct(int newInvSize, int newStackLimit)
        {
            maxInventorySize = newInvSize;
            stackLimit = newStackLimit;
            InventoryItems = new List<Inv_Item>();
        }

        public int GetMaxSize()
        {
            return maxInventorySize;
        }
        public bool CheckInventoryLimit()
        {
            Debug.Log($"*******************************************************************");
            Debug.Log($"[SYSTEM] - InventoryLimit is:  ({maxInventorySize})");
            Debug.Log($"[SYSTEM] - Current InventorySize is:  ({InventoryItems.Count + 1})");
            Debug.Log($"*******************************************************************");
            return (InventoryItems.Count < maxInventorySize);
        }
        public bool CheckItem(Inv_Item itemData)
        {
            if (InventoryItems.Contains(itemData))
            {
                Debug.Log($"[SYSTEM] - Inventory Contains ({itemData.ItemName})");
                return true;
            }
            Debug.Log($"[SYSTEM] - Inventory Does NOT Contain ({itemData.ItemName})");
            return false;
        }

        public List<Inv_Item> GetInventory()
        {
            return InventoryItems;
        }

        public void TakeAllItems(InventoryStruct Inv_addTo)
        {
            foreach (Inv_Item item in GetInventory())
            {
                Inv_addTo.AddItem(item);
            }
        }
        public void SetInventoryLimit(int newInvLimit)
        {
            maxInventorySize = newInvLimit;
            Debug.Log($"[SYSTEM] - Inventory Limit ({maxInventorySize})");
        }
        public void SetStackLimit(int newStackLimit)
        {
            stackLimit = newStackLimit;
            Debug.Log($"[SYSTEM] - Stack Limit ({stackLimit})");
        }
        public void JoinStack(Inv_Item itemData)
        {
            if (CheckItem(itemData) && itemData.Quantity < stackLimit)
            {
                Inv_Item item = InventoryItems.Find(x => x == itemData);
                int combinedQuantity = item.Quantity + itemData.Quantity;
                if (item.Quantity < stackLimit && combinedQuantity < stackLimit)
                {
                    InventoryItems.Remove(item);
                    itemData.Quantity = combinedQuantity;
                    Debug.Log("[SYSTEM] - Stack Joined (SUCCESS)");
                }
            }
            else
            {
                Debug.Log("[ERROR] - Stack Joined (FAILURE)");
            }
        }
        public void SplitStack(Inv_Item itemData)
        {
            if (!CheckInventoryLimit())
            {
                Debug.Log("[ERROR] - INVENTORY FULL");
            }
            else
            {
                if (itemData.Quantity > 1)
                {
                    itemData.Quantity /= 2;
                    Inv_Item newStack = new Inv_Item(itemData);
                    InventoryItems.Add(newStack);
                    Debug.Log($"[SYSTEM] - Item Split (SUCCESS)");
                }
            }
        }
        public void AddItem(Inv_Item itemData)
        {
            if (!CheckInventoryLimit())
            {
                Debug.Log("[ERROR] - INVENTORY FULL");
            }
            else
            {
                if (CheckItem(itemData))
                {
                    Inv_Item item = InventoryItems.Find(x => x == itemData);
                    item.Quantity++;
                }
                else
                {
                    InventoryItems.Add(itemData);
                }
                Debug.Log($"[SYSTEM] - Item Added ({itemData.ItemName})");
            }
        }
        public void RemoveItem(Inv_Item itemData)
        {
            if (!CheckItem(itemData))
            {
                Debug.Log($"[ERROR] - Item Removed (FAILURE)");
            }
            else
            {
                Inv_Item item = InventoryItems.Find(x => x == itemData);
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                }
                else 
                {
                    InventoryItems.Remove(itemData);
                }
                Debug.Log($"[SYSTEM] - Item Removed (SUCCESS)");
            }
        }
    }
}
