using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * 控制摄像机随鼠标移动
 */
public class WithMouse : MonoBehaviour
{
    public  Camera cam;

    void Update()
    {
        Vector3 fwd = cam.transform.forward;
        fwd.Normalize();
        if (Input.GetMouseButton(0))
        {
            Vector3 vaxis = Vector3.Cross(fwd, Vector3.right);
            transform.Rotate(vaxis, -Input.GetAxis("Mouse X"), Space.World );
            Vector3 haxis = Vector3.Cross(fwd, Vector3.up);
            transform.Rotate(haxis, -Input.GetAxis("Mouse Y"), Space.World);
        }
    }
}
