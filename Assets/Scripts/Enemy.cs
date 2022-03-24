using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(HealthSystem))]
[RequireComponent(typeof(AnimationController))]
[RequireComponent(typeof(MovementEnemy))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector2 sizeBox;
    
    private HealthSystem healthSystem;
    private AnimationController animationController;
    private MovementEnemy movement;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        animationController = GetComponent<AnimationController>();
        movement = GetComponent<MovementEnemy>();
    }

    private void FixedUpdate()
    {
        if (movement.moveUp)
        {
            animationController.MoveUp();
        } else
        {
            animationController.MoveDown();
        }


    }

    public void Hit(float damage)
    {
        healthSystem.Hit(damage);
        animationController.Hit();
    }
}
