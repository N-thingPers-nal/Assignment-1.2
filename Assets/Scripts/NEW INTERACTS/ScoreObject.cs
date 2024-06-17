using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Score Object", menuName = "Inventory System/Items/Score")]

public class ScoreObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Score;
    }
}
