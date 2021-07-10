using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    [SerializeField] const float moveSpeed = 800;

    public KeyCode key;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void MoveTo(Vector3 newPosition)
    {
        StartCoroutine(MoveTowardsLocal(this.transform, newPosition, moveSpeed));
    }

    public virtual void Use()
    {
        Debug.Log("generic icon use");
        // Destroy(gameObject);
    }

    IEnumerator MoveTowardsLocal(Transform transform, Vector3 newPosition, float speed)
    {
        while (transform.position != newPosition)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPosition, speed * Time.deltaTime);
            yield return null;
        }
    }
}