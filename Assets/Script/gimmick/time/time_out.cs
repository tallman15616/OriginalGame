using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_out : MonoBehaviour
{
    //タイム表示するスクリプト
    public Text timeUpText;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("PlayerArmature");

    }

    void Update()
    {
        Count_Reset();
    }

    void Count_Reset()
    {
        if(timeUpText != null)
        {
            player.SetActive(false);
        }
    }
}
