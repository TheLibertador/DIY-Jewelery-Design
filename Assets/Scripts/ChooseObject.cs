using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class ChooseObject : MonoBehaviour
{
    public string beadTag;
    private bool dragging = false;
    [SerializeField] private GameObject[] frames = new GameObject[3];
    [SerializeField] private GameObject[] beads = new GameObject[7];
    [SerializeField] private GameObject[] DaisyDoTweenTargets = new GameObject[3];
    [SerializeField] private GameObject[] GemDoTweenTargets = new GameObject[3];
    [SerializeField] private GameObject[] LetterDoTweenTargets = new GameObject[3];
    private GameObject newBead;

    private int touchCountForLetters = 0;

    private int touchCounter = 0;


    void Update()
    {
        if (touchCounter >= 4)
        {

            StartCoroutine(ChangeLevel());

        }
        if (Input.touchCount != 1)
        {
            dragging = false;
            return;
        }

        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == beadTag))
            {
                
                
                if(beadTag == "daisy")
                {
                    frames[1].SetActive(false);
                    frames[2].SetActive(false);
                    frames[0].SetActive(true);
                   
                    
                    if (touchCountForLetters == 0)
                    {
                        newBead = Instantiate(beads[0], new Vector3(0.58f, 4.22f, -2.68f), Quaternion.Euler(90, 0, 180));
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(DaisyDoTweenTargets[0].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(90f, 10.55f, 180),0);
                        newBead.transform.DOScale(new Vector3(0.40f, 0.40f, 0.40f), 1);
                        touchCountForLetters++;
                        
                    }

                    else if (touchCountForLetters == 1)
                    {
                        newBead = Instantiate(beads[0], new Vector3(0.58f, 4.22f, -2.68f), Quaternion.Euler(90, 0, 180));
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(DaisyDoTweenTargets[1].transform.position, 1);
                        newBead.transform.DOScale(new Vector3(0.40f, 0.40f, 0.40f), 1);
                        touchCountForLetters++;
                       
                    }
                   else if (touchCountForLetters == 2)
                    {
                        newBead = Instantiate(beads[0], new Vector3(0.58f, 4.22f, -2.68f), Quaternion.Euler(90, 0, 180));
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(DaisyDoTweenTargets[2].transform.position, 1);
                        newBead.transform.DOScale(new Vector3(0.40f, 0.40f, 0.40f), 1);
                        touchCountForLetters = 0;
                        Debug.Log(touchCountForLetters);
                    }
                }
                if (beadTag == "gem")
                {
                    frames[0].SetActive(false);
                    frames[1].SetActive(false);
                    frames[2].SetActive(true);

                    if (touchCountForLetters == 0)
                    {
                        newBead = Instantiate(beads[1], new Vector3(-0.46f, 2.86f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(GemDoTweenTargets[0].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-72.58f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.08f, 0.08f, 0.08f), 0);
                        touchCountForLetters++;

                    }

                    else if (touchCountForLetters == 1)
                    {
                        newBead = Instantiate(beads[5], new Vector3(-0.46f, 2.86f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(GemDoTweenTargets[1].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-39.49f, 11.72f, 2.13f), 0);
                        newBead.transform.DOScale(new Vector3(0.08f, 0.08f, 0.08f), 0);
                        touchCountForLetters++;

                    }
                    else if (touchCountForLetters == 2)
                    {
                        newBead = Instantiate(beads[6], new Vector3(-0.46f, 2.86f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(GemDoTweenTargets[2].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-137, 214.11f, -181.7f), 0);
                        newBead.transform.DOScale(new Vector3(0.08f, 0.08f, 0.08f), 0);
                        touchCountForLetters = 0;
                       
                    }


                }
                if (beadTag == "letter")
                {
                    frames[0].SetActive(false);
                    frames[2].SetActive(false);
                    frames[1].SetActive(true);
                    if(touchCountForLetters == 0)
                    {
                        newBead = Instantiate(beads[2], new Vector3(0.64f, 3.53f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(LetterDoTweenTargets[0].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(33.4f, 0.11f, -360), 0);
                        newBead.transform.DOScale(new Vector3(0.15f, 0.15f, 0.15f), 0);
                        touchCountForLetters++;
                    }
                    else if(touchCountForLetters == 1)
                    {
                        newBead = Instantiate(beads[3], new Vector3(0.64f, 3.53f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;
                        newBead.transform.DOMove(LetterDoTweenTargets[1].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(16.72f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.15f, 0.15f, 0.15f), 0);
                        touchCountForLetters++;
                    }
                    else if (touchCountForLetters == 2)
                    {
                        newBead = Instantiate(beads[4], new Vector3(0.64f, 3.53f, -2.07f), Quaternion.identity);
                        touchCounter = touchCounter + 1;                        
                        newBead.transform.DOMove(LetterDoTweenTargets[2].transform.position, 1);
                        newBead.transform.DORotate(new Vector3(20.84f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.15f, 0.15f, 0.15f), 0);
                        touchCountForLetters = 0;
                    }
                }
               

            }

        }
        if (dragging && touch.phase == TouchPhase.Moved)
        {
           
        }
        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
            Debug.Log("Our object is okey");
        }
    }


    private IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}

