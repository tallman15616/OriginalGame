using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_delete2 : MonoBehaviour
{
    //ƒ{[ƒ‹‚ÉÚG‚µ‚½‚Æ‚«ANPC‚ğíœ
    public string Tag_name = "Ball";

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Tag_name)
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}
