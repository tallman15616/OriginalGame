using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_ON : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //マウスポインターオフ
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
