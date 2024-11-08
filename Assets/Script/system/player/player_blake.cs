using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_blake : MonoBehaviour
{
    public GameObject target;
    public string Tag_name = "NPC";

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Tag_name)
        {
            target.gameObject.SetActive(false);
        }
    }
}
