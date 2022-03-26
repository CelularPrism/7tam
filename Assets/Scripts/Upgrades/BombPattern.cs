using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPattern : MonoBehaviour
{
    public float radius;
    public LayerMask layerPlayer;
    public float upgradePoint;
    public void FixedUpdate()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, layerPlayer);
        if (collider != null)
        {
            Upgrade(collider);
            Destroy(transform.gameObject);
        }
    }

    public virtual void Upgrade(Collider2D collider)
    {
        return;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
