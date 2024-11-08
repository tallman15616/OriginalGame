using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class effect_delete : MonoBehaviour
{
    //particleが起動してから2ｆ後にparticleをオフにする
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    void Update()
    {
        if (gameObject.activeSelf)
        {
            Invoke("effect", 2.0f);
        }
    }

    void effect()
    {
        this.gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
