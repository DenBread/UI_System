using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BtnAnimation : MonoBehaviour
{
    private Button _btn;

    private void Awake()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(StartAnimation);
    }
    
    private void StartAnimation()
    {
        transform.DOPunchScale(new Vector3(0.1f, 0.1f, 0.1f), 0.25f, 2)
            .OnComplete(()=>
            {
                transform.DOScale(Vector3.one, 0.25f);
            });
    }
}
