using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_rockon : MonoBehaviour
{
    public NPC_wark wark;
    public GameObject player;
    public NavMeshAgent agent;
    private void Start()
    {
        wark = GameObject.Find("Female 4 (1)").GetComponent<NPC_wark>();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            wark.enabled = false;
            agent.destination = player.transform.position;
        }
        else
        {
            wark.enabled = true;
        }
    }
}
