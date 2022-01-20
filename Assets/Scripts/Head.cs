using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private Transform head;
    private Transform body;
    private Rigidbody rigidbody;
    public float speed;
    public float XmouseSpeed;
    public float YmouseSpeed;
    void Start()
    {
        head = transform;
        body = transform.parent;
        rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float hroitzonal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(hroitzonal, 0, vertical);
        if(dir != Vector3.zero)
        {
            body.Translate(dir * Time.deltaTime * speed);
        }
        float mousex = Input.GetAxis("Mouse X");
        if(mousex != 0)
        {
            body.Rotate(Vector3.up, mousex * XmouseSpeed * Time.deltaTime);
        }
        float mousey = Input.GetAxis("Mouse Y");
        if (mousey != 0)
        {
            head.Rotate(Vector3.left, mousey * YmouseSpeed * Time.deltaTime);
        }
        if(Vector3.Angle(body.forward, head.forward) > 60)
        {
            head.Rotate(Vector3.left, -mousey * YmouseSpeed * Time.deltaTime);
        }
    }
}
