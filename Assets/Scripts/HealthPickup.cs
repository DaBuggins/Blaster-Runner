using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] int healthAmount = 100;
    [SerializeField] AudioClip pickupSFX;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerHealth>().IncreaseCurrentHealth(healthAmount);
            AudioSource.PlayClipAtPoint (pickupSFX, transform.position);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log ("Something else triggered");
        }
    }



}