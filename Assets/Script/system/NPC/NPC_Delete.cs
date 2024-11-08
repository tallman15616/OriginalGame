using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Delete : MonoBehaviour
{
    public string Tag_name = "Ball";
    private Vector3 npc_position;
    private Quaternion npc_rotation;

    private void Start()
    {
        npc_position = this.gameObject.transform.position;
        npc_rotation = this.gameObject.transform.rotation;
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Tag_name)
        {
            this.gameObject.transform.position = npc_position;
            this.gameObject.transform.rotation = npc_rotation;

            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
