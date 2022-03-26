using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSizeUpgrade : BombPattern
{
    public override void Upgrade(Collider2D collider)
    {
        collider.GetComponent<Player>().ChangeSizeBomb(upgradePoint);
    }
}
