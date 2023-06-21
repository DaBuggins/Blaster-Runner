using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

[SerializeField] float hitPoints = 100f;
[SerializeField] ParticleSystem hitSplatter;
[SerializeField] AudioClip deathSFX;
[SerializeField] AudioClip hitSFX;

bool isDead = false;

public bool IsDead()
{
    return isDead;
}


public void TakeDamage(float damage) 
{
    BroadcastMessage("OnDamageTaken");
    hitSplatter.Play();
    AudioSource.PlayClipAtPoint (hitSFX, transform.position);
    hitPoints -= damage;
    if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        AudioSource.PlayClipAtPoint (deathSFX, transform.position);
        GetComponent<Animator>().SetTrigger("die");
        GetComponent<CapsuleCollider>().enabled = false;
        Destroy(gameObject, 5);
    }
}
