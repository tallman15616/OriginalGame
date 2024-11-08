using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_3 : MonoBehaviour
{
    //partのlegの起動スクリプト
    //設定した床を踏むと2ｆ後にlegが出現
    //上に出現したlegが徐々に下に落ちてくる
    //5ｆを超える、又はplayerのactiveがオフになると、activeをオフにして初期位置へ
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
        //legの位置に　下方向　*　3　*　ゲーム内時間　を加算
        other.transform.position += Vector3.down * 3 * Time.deltaTime;
        time += Time.deltaTime;
    }
    private void Res()
    {
        //5ｆを超えた時、又はplayerのactiveがオフのときlegを初期化
        if (time >= 5f || player.activeSelf == false)
        {
            time = 0f;
            other.gameObject.transform.position = initialPosition;
            other.gameObject.transform.rotation = initialRotation;
            other.gameObject.SetActive(false);
        }
    }

}
