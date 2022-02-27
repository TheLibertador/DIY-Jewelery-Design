using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void FadeToLevel1 (int leveIndex)
    {
        animator.SetBool("fadeOut", true);
    }
}
