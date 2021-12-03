using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    public Animator Anim;
    public NavMeshAgent playerNavMeshAgent;
    public Camera playerCamara;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCamara.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;
            if (Physics.Raycast(myRay,out myRaycastHit))
            {
                playerNavMeshAgent.SetDestination(myRaycastHit.point);
            }
        }
        Anim.SetFloat("Vel", playerNavMeshAgent.velocity.magnitude/playerNavMeshAgent.speed);
    }
}
