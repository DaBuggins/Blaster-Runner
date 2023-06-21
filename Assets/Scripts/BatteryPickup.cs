using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{

    [SerializeField] float restoreAngle = 90f;
    [SerializeField]  float addIntensity =1f;
    [SerializeField] AudioClip pickupSFX;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightSystem>().AddLightIntensity(addIntensity);
            AudioSource.PlayClipAtPoint (pickupSFX, transform.position);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log ("Something else triggered");
        }
    }
}
