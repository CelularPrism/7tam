using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public bool isLive;

    private void Start()
    {
        isLive = true;
        health = maxHealth;
    }

    public void Heal(int health)
    {
        if (isLive)
        {
            while (health > 0 && this.health < maxHealth)
            {
                this.health++;
                health--;
            }
        }
    }

    public void Hit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            isLive = false;
            health = 0;
        }
    }
}
