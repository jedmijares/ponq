using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlQueue : MonoBehaviour
{
    [SerializeField] Queue controlQueue;
    [SerializeField] Icon[] controlIcons;

    public const int size = 5;

    // Start is called before the first frame update
    private void Start()
    {
        controlQueue = new Queue();
        AddIcon();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            AddIcon();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            UseIcon();
        }
    }

    public void AddIcon()
    {
        int randomIndex = Random.Range(0, controlIcons.Length);

        Icon newIcon = Instantiate(controlIcons[randomIndex], Vector3.zero, Quaternion.identity, this.transform);
        RectTransform rt = (RectTransform)newIcon.transform;
        rt.SetAnchor(AnchorPresets.TopLeft);
        Vector3 position = new Vector3(rt.rect.width, -rt.rect.height, 0);
        newIcon.transform.localPosition = position;
        controlQueue.Enqueue(newIcon);
    }

    public void UseIcon()
    {
        Icon nextIcon = (Icon)controlQueue.Dequeue();
        nextIcon.Use();
        // transform.position.x += (RectTransform)nextIcon.transform.
        Destroy(nextIcon.gameObject);
    }
}