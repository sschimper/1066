using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapestryScroller : MonoBehaviour
{
    public float speed = 0.3f;
    public float thresholdPosX = -5876.0f;
    private RectTransform rectTransform;

    void Update()
    {
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform.localPosition.x < thresholdPosX)
        {
            Vector3 startPos = new Vector3(thresholdPosX * (-1), 0);
            rectTransform.localPosition = startPos;
        }
        else
        {
            Vector3 offset = new Vector3((-1) * speed, 0);
            rectTransform.localPosition += offset;
        }     
    }
}
