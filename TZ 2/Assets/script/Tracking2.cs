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
        // �v���C���[��ǔ�����ꍇ
        if (m_isFollow)
        {
            // �v���C���[�̌��݈ʒu�֌������x�N�g�����쐬����
            var angle = Utils.GetAngle(
                transform.localPosition,
                PlayerMove.m_instance.transform.localPosition);
            var direction = Utils.GetDirection(angle);

            // �v���C���[�����݂�������Ɉړ�����
            transform.localPosition += direction * speed;

            // �v���C���[�����݂������������
            //var angles = transform.localEulerAngles;
            //angles.z = angle - 90;
            //transform.localEulerAngles = angles;
            return;
        }

        // �܂������ړ�����
        transform.localPosition += m_direction * speed;
    }
    void des()
    {
        Destroy(gameObject);
    }
}
