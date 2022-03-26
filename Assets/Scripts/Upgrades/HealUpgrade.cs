using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealUpgrade : BombPattern
{
    public new void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, Physics2D.AllLayers);
        foreach (Collider2D collider in colliders)
        {
            if (collider.GetComponent<HealthSystem>() != null)
            {
                Upgrade(collider);
                Destroy(transform.gameObject);
            }
        }
    }

    public override void Upgrade(Collider2D collider)
    {
        collider.GetComponent<HealthSystem>().Heal((int)upgradePoint);
    }
}
