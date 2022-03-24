using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isLive;

    private void Start()
    {
        isLive = true;
    }

    public void Hit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            isLive = false;
            Debug.Log("Dead");
        }
    }
}
