using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocity;
    private Vector3 direction = Vector3.forward - Vector3.up + Vector3.right;

    // Start is callead before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(direction * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            Vector3 flipper = other.transform.forward;
            flipper.x = Mathf.Abs(flipper.x);
            flipper.y = Mathf.Abs(flipper.y);
            flipper.z = Mathf.Abs(flipper.z);
            flipper = (-2 * flipper) + Vector3.one;
            direction = Vector3.Scale(flipper, direction);
        }
    }
}
