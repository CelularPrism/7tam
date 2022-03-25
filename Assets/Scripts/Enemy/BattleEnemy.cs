using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnemy : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float timeReloadHit;

    private float timeHit;

    private void Start()
    {
        timeHit = Time.time;
    }

    public void DamagePlayer(HealthSystem healthSystem)
    {
        if (timeHit + timeReloadHit < Time.time)
        {
            healthSystem.Hit(damage);
        }
    }
}
