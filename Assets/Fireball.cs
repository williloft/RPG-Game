using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> vfx = new List<GameObject> ();
    public rotatetomus rotatetomus;

    private GameObject effectspawn;
    private float timetofire = 0;

    // Start is called before the first frame update
    void Start()
    {
        effectspawn = vfx[0];        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time >= timetofire)
        {
            timetofire = Time.time +1 / effectspawn.GetComponent<FireballMovement>().firerade;
            SpawnVFX();
        }
    }
    void SpawnVFX()
    {
        GameObject vfx;

        if(firepoint != null)
        {
            vfx = Instantiate(effectspawn, firepoint.transform.position, Quaternion.identity);
            if(rotatetomus != null)
            {
                vfx.transform.localRotation = rotatetomus.Getrotasion(); 
            }
        }
    }
}
