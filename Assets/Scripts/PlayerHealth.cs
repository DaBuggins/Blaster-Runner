using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float hitPoints = 100;
    [SerializeField] TextMeshProUGUI healthText;

    

    

    void Update()
    {
       healthText.text = hitPoints.ToString();
    }




public void TakeDamage(float damage) 
{
    hitPoints -= damage;
    if (hitPoints <= 0)
    {
        GetComponent<DeathHandler>().HandleDeath();
        
    }
}

public void IncreaseCurrentHealth(int healthAmount)
{
    hitPoints += healthAmount;
}


}
