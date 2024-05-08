using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 追従するターゲットのTransformを指定する公開変数
    public Vector3 offset; // ターゲットとカメラの間のオフセット（距離）

    void LateUpdate()
    {
        // カメラの位置を、ターゲットの位置にオフセットを加えた位置に設定
        // LateUpdateはUpdateの後に呼び出されるため、ターゲットの位置が更新された後に実行される
        transform.position = target.position + offset;
    }
}

