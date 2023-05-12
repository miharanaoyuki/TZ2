using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking2 : MonoBehaviour
{

    public bool m_isFollow;
    private Vector3 m_direction;

    float speed;

   public float time;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
        Invoke("des",time);
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーを追尾する場合
        if (m_isFollow)
        {
            // プレイヤーの現在位置へ向かうベクトルを作成する
            var angle = Utils.GetAngle(
                transform.localPosition,
                PlayerMove.m_instance.transform.localPosition);
            var direction = Utils.GetDirection(angle);

            // プレイヤーが存在する方向に移動する
            transform.localPosition += direction * speed;

            // プレイヤーが存在する方向を向く
            //var angles = transform.localEulerAngles;
            //angles.z = angle - 90;
            //transform.localEulerAngles = angles;
            return;
        }

        // まっすぐ移動する
        transform.localPosition += m_direction * speed;
    }
    void des()
    {
        Destroy(gameObject);
    }
}
