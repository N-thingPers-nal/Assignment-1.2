using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStsts : CharacterStats
{
     public override void Death()
         {
           gameObject.SetActive(false);
         }
 
}



