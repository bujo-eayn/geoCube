using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool isPickedUp = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            rb.position = worldPosition;
        } 
    }
    void OnMouseDown()
    {
        isPickedUp = true;
        rb.useGravity = false;
    }

    void OnMouseUp()
    {
        isPickedUp = false;
        rb.useGravity = true;
    }
}
