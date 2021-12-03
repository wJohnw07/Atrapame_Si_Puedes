using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRespawn : MonoBehaviour

{
    public Transform player;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;


    }
}