using UnityEngine;

// �֗��Ȋ֐����Ǘ�����ÓI�N���X
public static class Utils
{
    // �ړ��\�Ȕ͈�
    public static Vector2 m_moveLimit = new Vector2(8.5f, 4.5f);

    // �w�肳�ꂽ�ʒu���ړ��\�Ȕ͈͂Ɏ��߂��l��Ԃ�
    public static Vector3 ClampPosition(Vector3 position)
    {
        return new Vector3
        (
            Mathf.Clamp(position.x, -m_moveLimit.x, m_moveLimit.x),
            Mathf.Clamp(position.y, -m_moveLimit.y, m_moveLimit.y),
            0
        );
    }

    // �w�肳�ꂽ 2 �̈ʒu����p�x�����߂ĕԂ�
    public static float GetAngle(Vector2 from, Vector2 to)
    {
        var dx = to.x - from.x;
        var dy = to.y - from.y;
        var rad = Mathf.Atan2(dy, dx);
        return rad * Mathf.Rad2Deg;
    }

    // �w�肳�ꂽ�p�x�i 0 �` 360 �j���x�N�g���ɕϊ����ĕԂ�
    public static Vector3 GetDirection(float angle)
    {
        return new Vector3
        (
            Mathf.Cos(angle * Mathf.Deg2Rad),
            Mathf.Sin(angle * Mathf.Deg2Rad),
            0
        );
    }
}