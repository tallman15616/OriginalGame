using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_wark : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Eria();
    }
    void Eria()
    {
        Vector3 randomPos = new Vector3(Random.Range(0,10), 0, Random.Range(-10, 30));
        agent.destination = randomPos;//destinaion�̖ڕW���W
        //Debug.Log(randomPos);
    }
    void Update()
    {
        if (agent.remainingDistance < 0.5f)//remainingDistance�̓S�[���܂ł̖ړI�n
        {
            Eria();
        }
    }
}