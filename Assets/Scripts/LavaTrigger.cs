using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class LavaTrigger : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PlayerManager.instance.KillPlayer();
        }
    }
}

