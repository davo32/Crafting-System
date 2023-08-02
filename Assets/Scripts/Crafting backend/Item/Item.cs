using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public Item() { }
    public Item(int id, string itemName)
    {
        Id = id;
        ItemName = itemName;
    }

    public int Id;
    public string ItemName;


}
