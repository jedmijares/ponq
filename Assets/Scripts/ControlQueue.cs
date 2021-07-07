using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlQueue : MonoBehaviour
{
    [SerializeField] List<Icon> controlQueue;
    [SerializeField] Icon[] controlIcons;

    public const int size = 5;

    // Start is called before the first frame update
    private void Start()
    {
        controlQueue = new List<Icon>();
        for (int i = 0; i < 10; ++i)
            AddIcon();
    }

    // Update is called once per frame
    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.C))
        // {
        //     AddIcon();
        // }
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
        newIcon.transform.localPosition = new Vector3(rt.rect.width, -1200, 0);
        newIcon.MoveTo(new Vector2(rt.rect.width, -rt.rect.height * controlQueue.Count));
        controlQueue.Add(newIcon);
    }

    public void UseIcon()
    {
        if (controlQueue.Count > 0)
        {
            Icon nextIcon = (Icon)controlQueue[0];
            nextIcon.Use();
            controlQueue.RemoveAt(0);
            Destroy(nextIcon.gameObject);

            int i = 0;
            foreach (Icon icon in controlQueue)
            {
                icon.StopAllCoroutines();
                RectTransform rt = (RectTransform)icon.transform;
                icon.MoveTo(new Vector2(rt.rect.width, -rt.rect.height * i));
                ++i;
            }
        }
        AddIcon();
    }
}