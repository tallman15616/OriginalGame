using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_On : MonoBehaviour
{
    //partが設定された床を踏むとfollowが起動
    //playerのactiveがオフになったとき、followもオフになる
    public GameObject follow;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("PlayerArmature");
        follow.SetActive(false);
    }

    private void Update()
    {
        Res();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            follow.SetActive(true);
        }
    }

    private void Res()
    {
        if (!player.activeSelf)
        {
            follow.SetActive(false);
        }
    }
}
