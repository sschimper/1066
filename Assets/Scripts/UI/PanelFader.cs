using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code taken from here: https://www.youtube.com/watch?v=YYD_tBBS4FY
public class PanelFader : MonoBehaviour
{
    public bool mFaded = false;
    public float duration = 0.3f;

    public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end)
    {
        float counter = 0.0f;

        while(counter < duration)
        {
            counter += Time.deltaTime;
            canvGroup.alpha = Mathf.Lerp(start, end, (counter / duration));

            yield return null;
        }
    }

    public void Fade()
    {
        var canvGroup = GetComponent<CanvasGroup>();
        mFaded = !mFaded;

        StartCoroutine(DoFade(canvGroup, canvGroup.alpha, mFaded ? 1 : 0));
    }
}
