using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Icon
{
    [SerializeField] private Paddle.PaddleDirection direction;
    [SerializeField] public Paddle paddle;

    public override void Use()
    {
        base.Use();
        paddle.Move(direction);
    }
}
