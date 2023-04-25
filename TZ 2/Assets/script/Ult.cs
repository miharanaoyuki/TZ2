using UnityEngine;

// �֗��Ȋ֐����Ǘ�����ÓI�N���X
public static class Ult
{
    

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