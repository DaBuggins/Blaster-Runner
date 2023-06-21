using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas hitEffectCanvas;
    [SerializeField] float hitTime = 0.3f;
    void Start()
    {
        hitEffectCanvas.enabled = false;
    }


    public void ShowDamageImpact()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        hitEffectCanvas.enabled = true;
        yield return new WaitForSeconds(hitTime);
        hitEffectCanvas.enabled = false;


    }

}
