using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Icon
{
    [SerializeField] private Paddle.PaddleDirection direction;
    public Paddle paddle;

    const float speed = 2F;



    public override void Use()
    {
        base.Use();

        StartCoroutine(MovePaddle(direction));
        // paddle.MoveOneUnit(direction);
    }

    IEnumerator MovePaddle(Paddle.PaddleDirection dir)
    {
        while (Input.GetKey(key))
        {
            switch (direction)
            {
                case Paddle.PaddleDirection.Up:
                    paddle.paddlePosition = paddle.paddlePosition + Vector2.up * speed * Time.deltaTime;
                    break;
                case Paddle.PaddleDirection.Down:
                    paddle.paddlePosition = paddle.paddlePosition + Vector2.down * speed * Time.deltaTime;
                    break;
                case Paddle.PaddleDirection.Right:
                    paddle.paddlePosition = paddle.paddlePosition + Vector2.right * speed * Time.deltaTime;
                    break;
                case Paddle.PaddleDirection.Left:
                    paddle.paddlePosition = paddle.paddlePosition + Vector2.left * speed * Time.deltaTime;
                    break;
            }
            yield return null;
        }
        Destroy(gameObject);
    }
}
