using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        TriggerDeathVFX();
        
        // TODO SFX death
        Destroy(gameObject);
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) return;

        Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFX, 1f);
    }
}
