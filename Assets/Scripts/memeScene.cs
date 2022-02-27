using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memeScene : MonoBehaviour
{
    [SerializeField] private GameObject _confetti1;
    [SerializeField] private GameObject _confetti2;
        // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(showConfetti());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator showConfetti()
    {
        yield return new WaitForSeconds(0.6f);
        _confetti1.SetActive(true);
        _confetti2.SetActive(true);
    }
    
}
