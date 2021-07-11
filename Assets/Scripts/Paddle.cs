using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;

    const float maxPositionY = 2;
    const float maxPositionX = 3;

    public enum PaddleDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public Vector2 paddlePosition
    {
        get
        {
            return transform.position;
        }
        set
        {
            float newX = Mathf.Clamp(value.x, -maxPositionX, maxPositionX);
            float newY = Mathf.Clamp(value.y, -maxPositionY, maxPositionY);
            transform.position = new Vector3(newX, newY, transform.position.z);
        }
    }


    // Start is called before the first frame update
    private void Start()
    {
        // targetPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        // KeyboardMovement();
    }

    // public void MoveOneUnit(PaddleDirection dir)
    // {
    //     switch (dir)
    //     {
    //         case PaddleDirection.Up:
    //             targetPosition.y += 1;
    //             targetPosition.y = Mathf.Clamp(targetPosition.y, -maxPosition, maxPosition);
    //             break;
    //         case PaddleDirection.Down:
    //             targetPosition.y -= 1;
    //             targetPosition.y = Mathf.Clamp(targetPosition.y, -maxPosition, maxPosition);
    //             break;
    //         case PaddleDirection.Right:
    //             targetPosition.x += 1;
    //             targetPosition.x = Mathf.Clamp(targetPosition.x, -maxPosition, maxPosition);
    //             break;
    //         case PaddleDirection.Left:
    //             targetPosition.x -= 1;
    //             targetPosition.x = Mathf.Clamp(targetPosition.x, -maxPosition, maxPosition);
    //             break;
    //     }
    // }

    // private void KeyboardMovement()
    // {
    //     // Vector3 pos = transform.position;

    //     if (Input.GetKeyDown("w"))
    //     {
    //         // pos.y += speed * Time.deltaTime;
    //         targetPosition.y += 1;
    //     }
    //     if (Input.GetKeyDown("s"))
    //     {
    //         //pos.y -= speed * Time.deltaTime;
    //         targetPosition.y -= 1;
    //     }
    //     if (Input.GetKeyDown("d"))
    //     {
    //         //pos.x += speed * Time.deltaTime;
    //         targetPosition.x += 1;
    //     }
    //     if (Input.GetKeyDown("a"))
    //     {
    //         //pos.x -= speed * Time.deltaTime;
    //         targetPosition.x -= 1;
    //     }
    // }
}