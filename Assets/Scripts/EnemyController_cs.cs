using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController_cs : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar_cs healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(1);
        }
        
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        Debug.Log("Took Damage!");

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}