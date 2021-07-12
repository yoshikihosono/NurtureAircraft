using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleText : MonoBehaviour
{
    public float DurationSeconds;
    public Ease easeType;
    Tweener tweener;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<CanvasGroup>().DOFade(0f, DurationSeconds).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tweener.Kill();
            DurationSeconds = 0.1f;
            tweener = GetComponent<CanvasGroup>().DOFade(0f, DurationSeconds).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
            tweener.Play();
        }
    }
}
