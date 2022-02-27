using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class FollowPath : MonoBehaviour
{
    public SelectionManager selectionManager;

    private Camera _cam;
    private Vector3 _clickPos;
    public PathCreator pathCreator;
    [SerializeField] private GameObject bead1;
    [SerializeField] private GameObject bead2;
    [SerializeField] private const int beadNum = 10;
    //public EndOfPathInstruction endOfPathInstruction;
    void Start()
    {
        _cam = Camera.main;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetMouseButton(0))
        {
                _clickPos = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -_cam.transform.position.z));

                if (selectionManager.MoveBead1())
                {
                    
                    //distanceTravelled += speed * Time.deltaTime;
                    //transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                    //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);

                    bead1.transform.position = Vector3.Lerp(transform.position, pathCreator.path.GetClosestPointOnPath(_clickPos), Time.deltaTime * 10);

                }

                if (selectionManager.MoveBead2())
                {
                    
                    //distanceTravelled += speed * Time.deltaTime;
                    //transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                    //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);

                    bead2.transform.position = Vector3.Lerp(transform.position, pathCreator.path.GetClosestPointOnPath(_clickPos), Time.deltaTime * 10);

                }
          
        }
    
    }
  
}
