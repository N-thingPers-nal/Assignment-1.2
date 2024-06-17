using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorKey : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject portalCollider;

    private void Start()
    {
        portalCollider.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            collectSound.Play();
            portalCollider.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}

