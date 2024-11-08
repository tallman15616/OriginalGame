using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_1 : MonoBehaviour
{
    //partのhandの起動スクリプト
    //設定した床を踏むと2ｆ後にhandが出現
    //後方から2ｆ後にhandが出現、徐々に前に進んでくる
    //playerのactiveがオフ、又は3f後にリセット
    public GameObject other;
    public GameObject player;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private float time = 0f;

    void Start()
    {
        other.gameObject.SetActive(false);
        initialPosition = other.gameObject.transform.position;
        initialRotation = other.gameObject.transform.rotation;
    }
    void Update()
    {
        //Debug.Log("(x, y, z) = " + other.transform.position);
        //Debug.Log(time);

        if (other.activeSelf)
        {
            Trap();
        }
        Res();
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("Porn", 2f);
        }
    }
    private void Porn()
    {
        other.gameObject.SetActive(true);
    }
    private void Trap()
    {
        //handの位置に　前方向　*　7　*　ゲーム内時間　を加算
        other.transform.position += Vector3.forward * 7 * Time.deltaTime;
        time += Time.deltaTime;
    }
    private void Res()
    {
        //3ｆを超えた時、又はplayerのactiveがオフのときhandを初期化
        if (time >= 3f || player.activeSelf == false)
        {
            time = 0f;
            other.gameObject.transform.position = initialPosition;
            other.gameObject.transform.rotation = initialRotation;
            other.gameObject.SetActive (false);
        }
    }
}
