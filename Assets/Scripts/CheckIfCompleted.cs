using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckIfCompleted : MonoBehaviour
{
    public bool bead1 = false;
    public bool bead2 = false;
    public bool bead3 = false;
    public bool bead4 = false;
    public bool bead5 = false;
    public bool bead6 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator LoadScene()
    {
        if (bead1 && bead2 && bead3 && bead4 && bead5 && bead6)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(2);
        }
    }
    public void updateBool(string beadNo)
    {
        switch (beadNo)
        {
            case "bead1":
                bead1 = true;
                break;
            case "bead2":
                bead2 = true;
                break;
            case "bead3":
                bead3 = true;
                break;
            case "bead4":
                bead4 = true;
                break;
            case "bead5":
                bead5 = true;
                break;
            case "bead6":
                bead6 = true;
                break;
        }

        StartCoroutine(LoadScene());

    }
}
