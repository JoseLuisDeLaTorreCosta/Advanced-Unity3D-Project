using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    Animator anim;
    float move, rot;
    NavMeshAgent agent;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (agent.velocity == Vector3.zero) move = 0;
        else move = 1;
        anim.SetFloat("move", move);
        rot = rb.rotation.y;
        anim.SetFloat("rot", rot);
    }
}
