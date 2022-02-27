using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoFinishScene : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(GoEndScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GoEndScene()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(5);
    }
}
