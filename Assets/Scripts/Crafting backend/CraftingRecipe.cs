using UnityEngine;
using InventoryBackend;
using System.Collections.Generic;

public class CraftingRecipe 
{
    private List<Inv_Item> itemsNeeded;
    private List<Inv_Item> CurrentItems;

    void AddItemToRecipe(Inv_Item itemAdd)
    {
        if (itemsNeeded.Contains(itemAdd))
        {
            if (!CurrentItems.Contains(itemAdd))
            {
                CurrentItems.Add(itemAdd);
                Debug.Log($"[SYSTEM] - Adding {itemAdd.ItemName} to crafting recipe!");
            }
            else
            {
                Debug.Log($"[SYSTEM] - CANNOT add {itemAdd.ItemName} to crafting recipe!");
            }
        }
    }
}
