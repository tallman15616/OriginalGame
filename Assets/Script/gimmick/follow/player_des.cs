using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_des : MonoBehaviour
{
    //player��active���I�t�ɂ���
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.gameObject.SetActive(false);
        }
    }
}
