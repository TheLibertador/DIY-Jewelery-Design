using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateBracelet : MonoBehaviour
{
    [SerializeField] private GameObject braceletTransform;
    [SerializeField] private Ease braceletEase;

    void Start()
    {
        braceletTransform.transform.DOLocalRotate(new Vector3(0,180,0), 3).SetLoops(-1,LoopType.Incremental).SetEase(braceletEase);
    }

   
}
