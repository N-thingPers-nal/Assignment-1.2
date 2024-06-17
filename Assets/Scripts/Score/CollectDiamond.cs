using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDiamond : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
