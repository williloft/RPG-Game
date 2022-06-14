using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetomus : MonoBehaviour
{
    public Camera cam;
    public float maxlang;

    private Ray raymus;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotasion;


    void Update()
    {
        if(cam != null)
        {
            RaycastHit hit;
            var mousepos = Input.mousePosition;
            raymus = cam.ScreenPointToRay(mousepos);

            if(Physics.Raycast(raymus.origin, direction, out hit, maxlang))
            {
                RotateToMouseDirection(gameObject, hit.point);
            }
            else
            {
                var pos = raymus.GetPoint(maxlang);
                RotateToMouseDirection(gameObject, pos);
            }

        }
    }
    
    void RotateToMouseDirection (GameObject obj, Vector3 destination)
    {
        direction = destination - obj.transform.position;
        rotasion = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotasion, 1);
    }
    public Quaternion Getrotasion()
    {
        return rotasion;
    }
}
