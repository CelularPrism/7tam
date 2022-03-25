using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HealthSystem))]
[RequireComponent(typeof(AnimationController))]
[RequireComponent(typeof(MovementEnemy))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private float radius;
    [SerializeField] private float damage;
    [SerializeField] private float timeReloadDirty;

    private HealthSystem healthSystem;
    private MovementEnemy movementEnemy;
    private AnimationController animationController;

    private bool dirty;
    private float timeDirty;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        animationController = GetComponent<AnimationController>();
        movementEnemy = GetComponent<MovementEnemy>();
        dirty = false;
    }

    void FixedUpdate()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, playerMask);
        if (collider != null)
        {
            collider.transform.GetComponent<HealthSystem>().Hit(damage);
            movementEnemy.isMove = false;
            animationController.Angry();
            movementEnemy.CheckMove(collider.transform.position);
        } else
        {
            movementEnemy.isMove = true;
            if (dirty)
                animationController.Hit();
            else
                animationController.Normal();
        }

        if (timeDirty + timeReloadDirty < Time.time)
        {
            dirty = false;
        }
    }

    public void Hit(float damage)
    {
        healthSystem.Hit(damage);
        animationController.Hit();
        timeDirty = Time.time;
        dirty = true;
    }
}
