using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    [SerializeField] private LayerMask pointMask;
    [SerializeField] private float radius;

    [SerializeField] private float speed;

    public bool moveUp;
    public bool moveRight;

    private Vector2 nowPoint;

    private void FixedUpdate()
    {
        FindPoint();
        CheckMove();
        transform.position = Vector2.MoveTowards(transform.position, nowPoint, speed * Time.deltaTime);
    }

    private void CheckMove()
    {
        moveUp = transform.position.y < nowPoint.y;
        moveRight = transform.position.x < nowPoint.x;
    }

    private void FindPoint()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, pointMask);
        int randIndex = Random.Range(0, colliders.Length);

        nowPoint = colliders[randIndex].transform.position;
    }
}
