using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    [SerializeField] private LayerMask pointMask;
    [SerializeField] private float radius;

    [SerializeField] private float speed;

    public bool isMove;

    private Vector3 nowPoint;
    private AnimationController animationController; 
    private int moveUp;
    private int moveRight;

    private void Start()
    {
        FindPoint();
        CheckMove(nowPoint);
        animationController = GetComponent<AnimationController>();
        isMove = true;
    }

    private void FixedUpdate()
    {
        if (isMove)
        {
            if (transform.position == nowPoint)
            {
                FindPoint();
                CheckMove(nowPoint);
                SetAnimationMove();
            }
            transform.position = Vector2.MoveTowards(transform.position, nowPoint, speed * Time.deltaTime);
        }
    }

    private void FindPoint()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, pointMask);
        int randIndex = Random.Range(0, colliders.Length);

        nowPoint = colliders[randIndex].transform.position;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }

    public void SetAnimationMove()
    {
        if (moveUp == -1)
        {
            animationController.MoveDown();
        }
        else if (moveUp == 1)
        {
            animationController.MoveUp();
        }

        if (moveRight == -1)
        {
            animationController.MoveLeft();
        }
        else if (moveRight == 1)
        {
            animationController.MoveRight();
        }
    }

    public void CheckMove(Vector3 position)
    {
        Vector3 nowPos = transform.position;

        if (nowPos.y == nowPoint.y && nowPos.x != nowPoint.x)
        {
            moveUp = 0;
            moveRight = nowPos.x < nowPoint.x ? 1 : (nowPos.x == position.x ? 0 : -1);
        } else
        {
            moveUp = nowPos.y < nowPoint.y ? 1 : (nowPos.y == position.y ? 0 : -1);
            moveRight = 0;
        }
    }
}
