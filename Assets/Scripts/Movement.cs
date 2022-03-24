using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rigidbody;
    private float horizontalSpeed;
    private float verticalSpeed;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (joystick.Horizontal > 0f)
        {
            horizontalSpeed = moveSpeed * Time.deltaTime;
        } else if (joystick.Horizontal < 0f)
        {
            horizontalSpeed = -moveSpeed * Time.deltaTime;
        } else
        {
            horizontalSpeed = 0f;
        }

        if (joystick.Vertical > 0f)
        {
            verticalSpeed = moveSpeed * Time.deltaTime;
        }
        else if (joystick.Vertical < 0f)
        {
            verticalSpeed = -moveSpeed * Time.deltaTime;
        }
        else
        {
            verticalSpeed = 0f;
        }

        Vector2 newPos = new Vector2(transform.position.x + horizontalSpeed, transform.position.y + verticalSpeed);
        rigidbody.MovePosition(newPos);
    }
}
