using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField]
    private Transform target;//対象(player)
    private float angle;//角度
    [SerializeField]
    private float rotateSpeed = 180f;//回転速度
    public Vector3 distanceFromTarget;//targetからの距離
    [SerializeField] private Transform _self;//自身の距離

    void Update()
    {
        this.transform.LookAt(target.transform);
        //　ユニットの位置 = ターゲットの位置 ＋ ターゲットから見たユニットの角度 ×　ターゲットからの距離
        transform.position = target.position + Quaternion.Euler(0f, angle, 0f) * distanceFromTarget;
        //　ユニットの角度を変更
        angle += rotateSpeed * Time.deltaTime;
        //　角度を0～360度の間で繰り返す
        angle = Mathf.Repeat(angle, 360f);
    }
}
