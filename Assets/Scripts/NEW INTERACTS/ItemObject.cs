using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Relic,
    Default,
    Score
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
}
