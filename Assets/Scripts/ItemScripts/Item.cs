using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
    //Blueprint for all items
{
    public int id;
    new public string name = "New Item"; //overide current name to use this instead
    public int value;
    public bool isDefaultItem = false;
    public Sprite icon = null;
    internal ItemObject item;

    public virtual void Use () //base method for all items. Individual functionality defined elsewhere
    {
        //Use item

        Debug.Log("Using " + name);
    }
}
