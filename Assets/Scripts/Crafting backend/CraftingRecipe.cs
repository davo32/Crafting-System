using UnityEngine;
using InventoryBackend;
using System.Collections.Generic;

namespace CraftingBackend
{
    public class CraftingRecipe
    {
        private Inv_Item craftableItem; //Craftable Item
        private List<Inv_Item> itemsNeeded; //recipe list
        private List<Inv_Item> CurrentItems; //inventory items

        public CraftingRecipe() { }
        public CraftingRecipe(Inv_Item craftableItem, List<Inv_Item> itemsNeeded, List<Inv_Item> currentItems)
        {
            this.craftableItem = craftableItem;
            this.itemsNeeded = itemsNeeded;
            CurrentItems = currentItems;
        }

        public void AddItemToRecipe(Inv_Item itemAdd)
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
        public void RemoveItemFromRecipe(Inv_Item itemRemove)
        {
            if (CurrentItems.Contains(itemRemove))
            {
                CurrentItems.Remove(itemRemove);
            }
        }

        //makes sure that all items are accounted for in the crafting slots
        public bool CheckItemsAreValid()
        {
            bool isValid = false;
            for (int i = 0; i < itemsNeeded.Count; i++)
            {
                if (itemsNeeded.Contains(CurrentItems[i]))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        //gets a reference to the items needed for the recipe
        public List<Inv_Item> GetRecipeItems()
        {
            return itemsNeeded;
        }

        //gets a reference to the Craftable Item
        public Inv_Item GetCraftableItem()
        {
            return craftableItem;
        }
    }
}
