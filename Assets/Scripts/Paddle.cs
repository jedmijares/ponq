using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;

    public Vector3 targetPosition;

    // Start is called before the first frame update
    private void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        KeyboardMovement();
    }

    private void KeyboardMovement()
    {
        // Vector3 pos = transform.position;

        if (Input.GetKeyDown("w"))
        {
            // pos.y += speed * Time.deltaTime;
            targetPosition.y += 1;
        }
        if (Input.GetKeyDown("s"))
        {
            //pos.y -= speed * Time.deltaTime;
            targetPosition.y -= 1;
        }
        if (Input.GetKeyDown("d"))
        {
            //pos.x += speed * Time.deltaTime;
            targetPosition.x += 1;
        }
        if (Input.GetKeyDown("a"))
        {
            //pos.x -= speed * Time.deltaTime;
            targetPosition.x -= 1;
        }
    }
}