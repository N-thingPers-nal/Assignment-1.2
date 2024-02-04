using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
    //Blueprint for all items
{
    new public string name = "New Item"; //overide current name to use this instead
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use () //base method for all items. Individual functionality defined elsewhere
    {
        //Use item

        Debug.Log("Using " + name);
    }
}
