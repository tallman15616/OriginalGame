using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using static UnityEngine.ParticleSystem;

public class NPC_effect : MonoBehaviour
{
    //NPCのparticleを起動するスクリプト
    public GameObject particle;
    public GameObject player;
    void Start()
    {
        particle.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        //接触したオブジェクトがplayerの時、接触位置にparticleを起動
        if (other.gameObject == player)
        {
            particle.gameObject.SetActive(true);
            //foreach (ContactPoint point in other.contacts)
            //{
            //GameObject effest = Instantiate(particle) as GameObject;
            particle.transform.position = other.contacts[0].point;
            //}
        }
    }
}
