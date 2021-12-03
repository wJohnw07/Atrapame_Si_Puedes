using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveRandom : MonoBehaviour
{
    private NavMeshAgent agent = null;
    private GameObject[] RandomPoints;
    private int RandomA;
    public Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        RandomPoints = GameObject.FindGameObjectsWithTag("RandomPoints");
        Debug.Log("RandomPoints-"+ RandomPoints.Length.ToString());
    }

    // Update is called once per frame
    private void Update()
    {
        if (agent.hasPath== false)
        {
            RandomA = Random.Range(0, RandomPoints.Length + 1);
            agent.SetDestination(RandomPoints[RandomA].transform.position);
            Debug.Log("Moviendose" + RandomA.ToString());
        }
        Anim.SetFloat("Vel", agent.velocity.magnitude / agent.speed);
    }
}
