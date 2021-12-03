using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public NavMeshAgent agent;
    public bool Seguir;
    public Animator Anim;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position,this.transform.position);
        if (distance <= 5)
        {
            Seguir = true;
        }
        if(distance > 3f)
        {
            Seguir = false;
        }
        if (Seguir)
        {
            agent.SetDestination(player.transform.position);
            agent.isStopped = false;
        }
        if (!Seguir)
        {
            agent.isStopped = true;
        }
        Anim.SetFloat("Vel", agent.velocity.magnitude / agent.speed);
    }
}

