using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class SelectionManager : MonoBehaviour
{
    public Camera _cam;
    private Vector3 _clickPos;
    [SerializeField] private string bead1 = "bead1";
    [SerializeField] private string bead2 = "bead2";

    private Transform _selection;
    public bool bead1CanMove = false;
    public bool bead2CanMove = false;


    void Update()
    {
        if(_selection != null)
        {
            bead1CanMove = false;
            bead2CanMove = false;
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition.x);
            Debug.Log(Input.mousePosition.y);
            Debug.Log(_cam.transform.position.z);


            _clickPos = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -_cam.transform.position.z));
            var ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -_cam.transform.position.z));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                var selectionRenderer = selection.GetComponent<Renderer>();

                if (selection.CompareTag("bead1"))
                {
                    if (selectionRenderer != null)
                    {

                        bead1CanMove = true;
                    }
                }
                else if (selection.CompareTag("bead2"))
                {
                    if (selectionRenderer != null)
                    {
                        bead2CanMove = true;
                    }
                }
                _selection = selection;

            }

        }


    }
    public bool MoveBead1()
    {
        return bead1CanMove;
    }
    public bool MoveBead2()
    {
        return bead2CanMove;
    }
}
