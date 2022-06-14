using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    public GameObject player;
    public float targetdes;
    public float alloweddes = 2;
    public GameObject NPC;
    public float followspeed;
    public RaycastHit shot;
    private bool idelNpc;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        
        
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out shot))
        {
            targetdes = shot.distance;
            
            
            if(targetdes >= alloweddes)
            {
                followspeed = 0.1f;
                idelNpc = false;
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, followspeed);
            }
            
            else if(targetdes < alloweddes)
            {
                followspeed = 0;
                idelNpc = true;
            }
            animator.SetBool("idelNpc", idelNpc);
        }
    }
}
