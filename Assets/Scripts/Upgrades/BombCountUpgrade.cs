using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCountUpgrade : BombPattern
{
    public override void Upgrade(Collider2D collider)
    {
        collider.GetComponent<Player>().ChangeCountBomb((int)upgradePoint);
    }
}
