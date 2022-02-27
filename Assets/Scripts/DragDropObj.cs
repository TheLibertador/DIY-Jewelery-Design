using System;
using System.Collections;
using UnityEngine;
using PathCreation;

/*
public class DragDropObj : MonoBehaviour
{

    public string draggingTag;
    public Camera cam;

    private Vector3 dis;
    private float posX;
    private float posY;

    private bool touched = false;
    private bool dragging = false;

    private Transform toDrag;
    private Rigidbody toDragRigidbody;
    private Vector3 previousPosition;

    public PathCreator pathCreator;

    void FixedUpdate()
    {
        if (Input.touchCount != 1)
        {
            dragging = false;
            touched = false;
            return;
        }

        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;

        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(pos);

            if (Physics.Raycast(ray, out hit) &&  hit.collider.tag == draggingTag)
            {
                toDrag = hit.transform;
                previousPosition = toDrag.position;
                toDragRigidbody = toDrag.GetComponent<Rigidbody>();

                dis = cam.WorldToScreenPoint(previousPosition);
                posX = Input.GetTouch(0).position.x - dis.x;
                posY = Input.GetTouch(0).position.y - dis.y;
                touched = true;
            }
        }

        if (touched && touch.phase == TouchPhase.Moved)
        {
            dragging = true;

            float posXNow = Input.GetTouch(0).position.x - posX;
            float posYNow = Input.GetTouch(0).position.y - posY;
            Vector3 curPos = new Vector3(posXNow, posYNow, dis.z);

            Vector3 worldPos = cam.ScreenToWorldPoint(curPos) - previousPosition;
            worldPos = new Vector3(worldPos.x, worldPos.y, 0.0f);
            // gameObject.transform.position = pathCreator.path.GetClosestPointOnPath(worldPos);
            gameObject.transform.position = curPos;
            //toDragRigidbody.velocity = worldPos / (Time.deltaTime * 5);

            previousPosition = toDrag.position;
        }

        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled))
        {
            dragging = false;
            touched = false;
            previousPosition = new Vector3(0.0f, 0.0f, 0.0f);
        }

    }
    
}

*/



 
public class DragDropObj : MonoBehaviour {
    
    private float dist;
    private bool dragging = false;
    private Vector3 offset;
    public GameObject _particle;
    public string draggingTag;
    public PathCreator pathCreator;
    [SerializeField] private string index;
    [SerializeField] private GameObject[] BeadPositions;
    [SerializeField] private CheckIfCompleted _checkIfCompleted;
    [SerializeField] private GameObject[] fakeBeads = new GameObject[6];
    [SerializeField] private CameraShake ShakeScript;


    private void Start()
    {
        pathCreator = GameObject.Find("Path").GetComponent<PathCreator>();
    }
    void Update() {
        Vector3 v3;
 
        if (Input.touchCount != 1) {
            dragging = false; 
            return;
        }
 
        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;
 
        if(touch.phase == TouchPhase.Began) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(pos); 
            if(Physics.Raycast(ray, out hit) && (hit.collider.tag == draggingTag))
            {
                Debug.Log ("Here");
                dist = hit.transform.position.z - Camera.main.transform.position.z;
                v3 = new Vector3(pos.x, pos.y, dist);
                v3 = Camera.main.ScreenToWorldPoint(v3);
                offset = gameObject.transform.position - v3;
                dragging = true;
               


            }
            
        }
        if (dragging && touch.phase == TouchPhase.Moved) {
            v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            v3 = Camera.main.ScreenToWorldPoint(v3);
           // toDrag.position = v3 + offset;
            gameObject.transform.position = pathCreator.path.GetClosestPointOnPath(v3+offset);
        }
        if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)) {
            dragging = false;

           
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == index)
        {
            Instantiate(_particle, transform.position, Quaternion.identity);
            _checkIfCompleted.updateBool(draggingTag);
            ShakeScript.shakeDuration = 0.2f;
        }
    }

    public void GetDraggingTag(string tag)
    {
        draggingTag = tag;
        
    }
}