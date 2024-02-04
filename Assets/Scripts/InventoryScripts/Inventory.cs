using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one inventory found");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();  // deligate to call all subscribed methods within
    public OnItemChanged onItemChangedCallback; 

    public int space = 10;

    public List<Item> items = new List<Item>();

   public bool Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space) // check inventory space before adding item
            {
                Debug.Log("Not enough space");
                return false;
            }

            items.Add(item);

            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke(); // triggering event - update UI
        }

        return true;
    }

    public void Remove (Item item)
    {
        items.Remove (item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
