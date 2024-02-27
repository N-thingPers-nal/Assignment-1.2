using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDiamond : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Destroy(gameObject);

        ScoringSystem.instance.AddPoint();
    }
}
