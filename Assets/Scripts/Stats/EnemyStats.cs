using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public override void Death()
    {
        base.Death();

        // add death animation

        Destroy(gameObject);
    }
}
