using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRotator : MonoBehaviour
{
    public int angle = 0;
    private const float smooth = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            angle += 90;
        }
        if (Input.GetKeyDown("e"))
        {
            angle -= 90;
        }

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, 0, angle);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}