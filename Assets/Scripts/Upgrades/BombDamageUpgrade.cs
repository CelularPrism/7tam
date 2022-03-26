using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamageUpgrade : BombPattern
{
    public override void Upgrade(Collider2D collider)
    {
        collider.GetComponent<Player>().ChangeDamageBomb(upgradePoint);
    }
}
