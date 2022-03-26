using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AnimationController))]
public class Movement : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float moveSpeed;

    private AnimationController animationController;
    private Rigidbody2D rigidbody;
    private float horizontalSpeed;
    private float verticalSpeed;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<AnimationController>();
    }

    void Update()
    {

        if (joystick.Vertical > 0f)
        {
            verticalSpeed = moveSpeed * Time.deltaTime;
            animationController.MoveUp();
        }
        else if (joystick.Vertical < 0f)
        {
            verticalSpeed = -moveSpeed * Time.deltaTime;
            animationController.MoveDown();
        }
        else
        {
            verticalSpeed = 0f;
        }

        if (joystick.Horizontal > 0f)
        {
            horizontalSpeed = moveSpeed * Time.deltaTime;
            animationController.MoveRight();
        } else if (joystick.Horizontal < 0f)
        {
            horizontalSpeed = -moveSpeed * Time.deltaTime;
            animationController.MoveLeft();
        } else
        {
            horizontalSpeed = 0f;
        }

        Vector2 newPos = new Vector2(transform.position.x + horizontalSpeed, transform.position.y + verticalSpeed);
        rigidbody.MovePosition(newPos);
    }
}
