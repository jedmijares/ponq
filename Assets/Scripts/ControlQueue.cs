using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlQueue : MonoBehaviour
{
    const float iconHeight = 200;

    [SerializeField] List<Icon> controlQueue;
    [SerializeField] Icon[] controlIcons;

    [SerializeField] Paddle paddle;

    [SerializeField] KeyCode key;

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
        if (Input.GetKeyDown(key))
        {
            UseIcon();
        }
    }

    public void AddIcon()
    {
        int randomIndex = Random.Range(0, controlIcons.Length);
        Icon newIcon = Instantiate(controlIcons[randomIndex], this.transform);
        newIcon.key = key;
        newIcon.GetComponent<Move>().paddle = paddle;
        RectTransform rt = (RectTransform)newIcon.transform;
        rt.SetAnchor(AnchorPresets.TopCenter);
        newIcon.transform.localPosition = new Vector3(0, -1200, 0);
        newIcon.MoveTo(new Vector2(0, -iconHeight * controlQueue.Count));
        controlQueue.Add(newIcon);
    }

    public void UseIcon()
    {
        if (controlQueue.Count > 0)
        {
            Icon nextIcon = (Icon)controlQueue[0];
            nextIcon.Use();
            controlQueue.RemoveAt(0);
            // Destroy(nextIcon.gameObject);

            int i = 0;
            foreach (Icon icon in controlQueue)
            {
                icon.StopAllCoroutines();
                RectTransform rt = (RectTransform)icon.transform;
                icon.MoveTo(new Vector2(0, -iconHeight * i));
                ++i;
            }
        }
        AddIcon();
    }
}