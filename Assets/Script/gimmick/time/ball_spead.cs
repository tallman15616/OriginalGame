using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spead : MonoBehaviour
{
    Rigidbody rb;

    void Update()
    {
        Upspeed();
    }

    void Upspeed()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
        Vector3 force = new Vector3(0.0f, 0.0f, -5.0f);    // —Í‚ğİ’è
        rb.AddForce(force);  // —Í‚ğ‰Á‚¦‚é
    }
}
