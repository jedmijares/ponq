using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;

    public Vector3 direction;

    private void Start()
    {
        direction = 2 * Vector3.forward - Vector3.up - Vector3.right;
        if (Random.value > 0.5)
        {
            direction += Vector3.up * 2;
        }
        if (Random.value > 0.5)
        {
            direction += Vector3.right * 2;
        }
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // bounce ball upon hitting wall
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