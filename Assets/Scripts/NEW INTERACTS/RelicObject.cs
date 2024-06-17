using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Relic Object", menuName = "Inventory System/Items/Relic")]

public class RelicObject : ItemObject
{
    public int restoreHealthValue;
    private void Awake()
    {
        type = ItemType.Relic;
    }
}
