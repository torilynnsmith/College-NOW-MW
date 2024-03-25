using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //IN CLASS COLLEGE NOW MW

    //GLOBAL VARIABLES
    private bool isDragging = false;
    private Vector3 offset; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            //Debug.Log("isDragging");
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    //DRAG
    private void OnMouseDown()
    {
        //Debug.Log("mouse clicked");
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
        //ebug.Log("isDragging = " + isDragging);
    }

    //STOP DRAGGING
    private void OnMouseUp()
    {
        //Debug.Log("mouse released");
        isDragging = false;
        //Debug.Log("isDragging = " + isDragging);

    }
}
