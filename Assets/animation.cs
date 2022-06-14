using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private bool idel;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(idel == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                idel = false;
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                idel = false;
            }

            if (Input.GetKey(KeyCode.S))
            {
                idel = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                idel = false;
            }
        }
        animator.SetBool("idel", idel);
        idel = true;
    }
}
