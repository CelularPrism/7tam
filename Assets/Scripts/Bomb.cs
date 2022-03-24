using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float timeExplosion;
    [SerializeField] private float damage;
    [SerializeField] private Vector2 sizeBox;
    private float timeSpawn;

    private void Start()
    {
        timeSpawn = Time.time;
    }

    void Update()
    {
        if (timeSpawn + timeExplosion < Time.time)
        {
            Explode();
        }
    }

    private void Explode()
    {
        Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, sizeBox, 0f, Physics2D.AllLayers);
        foreach (Collider2D collider in colliders)
        {
            GameObject gameObject = collider.gameObject;
            string layer = LayerMask.LayerToName(gameObject.layer);
            if (layer == "Enemy")
            {
                gameObject.GetComponent<Enemy>().Hit(damage);
            }
        }
        Destroy(transform.gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawCube(transform.position, sizeBox);
    }
}
