using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    // [SerializeField] const float height = 200;
    [SerializeField] const float moveSpeed = 800;
    // [SerializeField] private Vector2 nextPosition;


    // Start is called before the first frame update
    private void Start()
    {
        // MoveUp();
    }

    // Update is called once per frame
    private void Update()
    {
        // Use();
        // MoveUp();
    }

    public void MoveTo(Vector3 newPosition)
    {
        // if (this.transform.localPosition.y < -height)
        // {
        //     transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        // }
        StartCoroutine(MoveTowardsLocal(this.transform, newPosition, moveSpeed));
    }

    public virtual void Use()
    {
        Debug.Log("generic icon use");
        // Destroy(gameObject);
    }

    // public void SetPosition(Vector2 newPosition)
    // {
    //     nextPosition = newPosition;

    // }

    IEnumerator MoveTowardsLocal(Transform transform, Vector3 newPosition, float speed)
    {
        while (transform.position != newPosition)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPosition, speed * Time.deltaTime);
            yield return null;
        }
    }
}