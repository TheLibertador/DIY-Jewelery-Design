using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBeadOnScene : MonoBehaviour
{
    public string beadTag;
    private bool dragging = false;

    [SerializeField] GameObject[] beads = new GameObject[5];

   
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

                if(beadTag == "daisy")
                {
                    Instantiate(beads[0], new Vector3(0.22f, 2.71f, 4.93f), Quaternion.Euler(90,0,0));
                }
                if(beadTag == "gem")
                {
                    Instantiate(beads[1], new Vector3(0.22f, 2.71f, 4.93f), Quaternion.identity);
                }
                if(beadTag == "AHarfi")
                {
                    Instantiate(beads[2], new Vector3(0.22f, 2.71f, 4.93f), Quaternion.identity);
                }
                if (beadTag == "MHarfi")
                {
                    Instantiate(beads[3], new Vector3(0.22f, 2.71f, 4.93f), Quaternion.identity);
                }
                if (beadTag == "YHarfi")
                {
                    Instantiate(beads[4], new Vector3(0.22f, 2.71f, 4.93f), Quaternion.identity);
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
