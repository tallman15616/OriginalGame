using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    //落ちる床のスクリプト
    Rigidbody rb;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;//落ちないようにするもの
        initialPosition = this.gameObject.transform.position;
        initialRotation = this.gameObject.transform.rotation;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("Fall", 3f);
        }
    }

    private void Fall()
    {
        //iskinematicをオフにして落下。5ｆ後にRespornを起動
        rb.isKinematic = false;
        Invoke("Resporn", 5f);
    }

    private void Resporn()
    {
        //isKinematicを起動。この床を初期位置に戻す
        rb.isKinematic = true;
        this.gameObject.transform.position = initialPosition;
        this.gameObject.transform.rotation = initialRotation;
    }
}
