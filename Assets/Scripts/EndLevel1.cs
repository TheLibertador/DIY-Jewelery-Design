using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using Tabtale.TTPlugins;

public class EndLevel1 : MonoBehaviour
{
    [SerializeField] private Transform camTransform;
    public FadeInOut fadeInOut;

    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;



    private void Start()
    {
        
        StartCoroutine(RotateCam());
        StartCoroutine(FadeOut());
        StartCoroutine(FinishScene());
    }

    
    private IEnumerator RotateCam()
    {
        yield return new WaitForSeconds(5);
        text1.SetActive(false);
        text2.SetActive(false);
        camTransform.DORotate(new Vector3(56.54f, 0, 0), 1);
        camTransform.DOMove(new Vector3(-0.1f, 1.42f, -6.31f), 1);
    }

    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(6);
        fadeInOut.FadeToLevel1(0); 
    }
    private IEnumerator FinishScene()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(1);
    }
    
    private void Awake()
    {
        // Initialize CLIK
        TTPCore.Setup();
        // Your code here
    }
}


