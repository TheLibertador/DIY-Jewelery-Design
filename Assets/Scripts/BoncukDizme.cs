using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class BoncukDizme : MonoBehaviour
{
    public string beadTag;
    private bool dragging = false;
    [SerializeField] private GameObject[] beads = new GameObject[7];
    private GameObject newBead;

    private int touchCountForLetters = 0;

    [SerializeField] private GameObject beadTarget;
    [SerializeField] private GameObject gemBirth;
    [SerializeField] private GameObject letterBirth;
    [SerializeField] private GameObject daisyBirth;

    public DragDropObj dragDropobj;

    private GameObject[] daisies = new GameObject[3];
    private GameObject[] gems = new GameObject[3];
    private GameObject[] letters = new GameObject[3];


    

    void Update()
    {
       
       
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

               
                if (beadTag == "daisy")
                {
                    if (touchCountForLetters == 0)
                    {
                        if(daisies[1] != null)
                        {
                            daisies[1].GetComponent<DragDropObj>().enabled = false;
                            
                        }
                        if(daisies[2] != null)
                        {
                            daisies[2].GetComponent<DragDropObj>().enabled = false;
                        }
                        
                        
                        newBead = Instantiate(beads[0], daisyBirth.transform.position, Quaternion.Euler(90, 0, 180));
                        
                        daisies[0] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(14.01f, -180f, 0), 0);
                        newBead.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
                        newBead.tag = "papatya";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("papatya");
                        
                        touchCountForLetters++;

                    }

                    else if (touchCountForLetters == 1)
                    {
                        if (daisies[0] != null)
                        {
                            daisies[0].GetComponent<DragDropObj>().enabled = false;
                            
                            
                        }
                        if (daisies[2] != null)
                        {
                            daisies[2].GetComponent<DragDropObj>().enabled = false;
                        }

                        
                        newBead = Instantiate(beads[0], daisyBirth.transform.position, Quaternion.Euler(90, 0, 180));
                        
                        daisies[1] =  newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(14.01f, -180f, 0), 0);
                        newBead.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
                        newBead.tag = "papatya";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("papatya");

                        touchCountForLetters++;

                    }
                    else if (touchCountForLetters == 2)
                    {
                        if (daisies[0] != null)
                        {
                            daisies[0].GetComponent<DragDropObj>().enabled = false;
                           
                        }
                        if(daisies[1] != null)
                        {
                            daisies[1].GetComponent<DragDropObj>().enabled = false;
                        }

                        
                        newBead = Instantiate(beads[0], daisyBirth.transform.position, Quaternion.Euler(90, 0, 180));
                       
                        daisies[2] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(14.01f, -180f, 0), 0);
                        newBead.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
                        newBead.tag = "papatya";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("papatya");
                        touchCountForLetters = 0;
                        Debug.Log(touchCountForLetters);
                    }
                }
                if (beadTag == "gem")
                {
                    
                    if (touchCountForLetters == 0)
                    {
                        if(gems[1] != null)
                        {
                            gems[1].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (gems[2] != null)
                        {
                            gems[2].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[1], gemBirth.transform.position, Quaternion.identity);
                        
                        gems[0] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-14.48f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.2f, 0.2f, 0.2f), 0);
                        newBead.tag = "hexgon";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("hexgon");
                        touchCountForLetters++;

                    }

                    else if (touchCountForLetters == 1)
                    {
                        if (gems[0] != null)
                        {
                            gems[0].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (gems[2] != null)
                        {
                            gems[2].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[5], gemBirth.transform.position, Quaternion.identity);
                        
                        gems[1] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-14.48f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.2f, 0.2f, 0.2f), 0);
                        newBead.tag = "hexgon";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("hexgon");
                        touchCountForLetters++;

                    }
                    else if (touchCountForLetters == 2)
                    {
                        if (gems[0] != null)
                        {
                            gems[0].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (gems[1] != null)
                        {
                            gems[1].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[6], gemBirth.transform.position, Quaternion.identity);
                        
                        gems[1] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(-14.48f, 0.11f, 0), 0);
                        newBead.transform.DOScale(new Vector3(0.2f, 0.2f, 0.2f), 0);
                        newBead.tag = "hexgon";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("hexgon");
                        touchCountForLetters = 0;
                        Debug.Log(touchCountForLetters);
                    }


                }
                if (beadTag == "letter")
                {
                    
                    if (touchCountForLetters == 0)
                    {
                        if (letters[1] != null)
                        {
                            letters[1].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (letters[2] != null)
                        {
                            letters[2].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[2], letterBirth.transform.position, Quaternion.identity);
                       
                        letters[0] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(77.16f, 0, -360), 0);
                        newBead.transform.DOScale(new Vector3(0.45f, 0.45f, 0.45f), 0);
                        newBead.tag = "harf";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("harf");
                        touchCountForLetters++;
                    }
                    else if (touchCountForLetters == 1)
                    {
                        if (letters[0] != null)
                        {
                            letters[0].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (letters[2] != null)
                        {
                            letters[2].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[3], letterBirth.transform.position, Quaternion.identity);
                       
                        letters[1] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(77.16f, 0, -360), 0);
                        newBead.transform.DOScale(new Vector3(0.45f, 0.45f, 0.45f), 0);
                        newBead.tag = "harf";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("harf");
                        touchCountForLetters++;
                    }
                    else if (touchCountForLetters == 2)
                    {
                        if (letters[0] != null)
                        {
                            letters[0].GetComponent<DragDropObj>().enabled = false;
                        }
                        if (letters[1] != null)
                        {
                            letters[1].GetComponent<DragDropObj>().enabled = false;
                        }
                        newBead = Instantiate(beads[4], letterBirth.transform.position, Quaternion.identity);
                       
                        letters[2] = newBead;
                        newBead.transform.DOMove(beadTarget.transform.position, 1);
                        newBead.transform.DORotate(new Vector3(77.16f, 0, -360), 0);
                        newBead.transform.DOScale(new Vector3(0.45f, 0.45f, 0.45f), 0);
                        newBead.tag = "harf";
                        newBead.AddComponent<DragDropObj>();
                        newBead.GetComponent<DragDropObj>().GetDraggingTag("harf");
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

        }
    }
}

