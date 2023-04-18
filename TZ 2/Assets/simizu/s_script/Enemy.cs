using UnityEngine;

// �G�̏o���ʒu�̎��
public enum RESPAWN_TYPE
{
    UP,    // ��
    RIGHT, // �E
    DOWN,  // ��
    LEFT,  // ��
    SIZEOF,// �G�̏o���ʒu�̐�
}

// �G�𐧌䂷��R���|�[�l���g
public class Enemy : MonoBehaviour
{
    public Vector2 m_respawnPosInside; // �G�̏o���ʒu�i�����j
    public Vector2 m_respawnPosOutside; // �G�̏o���ʒu�i�O���j
    public float m_speed; // �ړ����鑬��
    //public int m_hpMax; // HP �̍ő�l
    //public int m_exp; // ���̓G��|�������Ɋl���ł���o���l
    //public int m_damage; // ���̓G���v���C���[�ɗ^����_���[�W
    //private int m_hp; // HP
    private Vector3 m_direction; // �i�s����
    public bool m_isFollow; // �v���C���[��ǔ�����ꍇ true

    // �G���������ꂽ���ɌĂяo�����֐�
    private void Start()
    {
        // HP ������������
        //m_hp = m_hpMax;
    }

    // ���t���[���Ăяo�����֐�
    private void Update()
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
            transform.localPosition += direction * m_speed;

            // �v���C���[�����݂������������
            var angles = transform.localEulerAngles;
            angles.z = angle - 90;
            transform.localEulerAngles = angles;
            return;
        }

        // �܂������ړ�����
        transform.localPosition += m_direction * m_speed;
    }

    // �G���o�����鎞�ɏ���������֐�
    public void Init(RESPAWN_TYPE respawnType)
    {
        var pos = Vector3.zero;

        // �w�肳�ꂽ�o���ʒu�̎�ނɉ����āA
        // �o���ʒu�Ɛi�s���������肷��
        switch (respawnType)
        {
            // �o���ʒu����̏ꍇ
            case RESPAWN_TYPE.UP:
                pos.x = Random.Range(
                    -m_respawnPosInside.x, m_respawnPosInside.x);
                pos.y = m_respawnPosOutside.y;
                m_direction = Vector2.down;
                break;

            // �o���ʒu���E�̏ꍇ
            case RESPAWN_TYPE.RIGHT:
                pos.x = m_respawnPosOutside.x;
                pos.y = Random.Range(
                    -m_respawnPosInside.y, m_respawnPosInside.y);
                m_direction = Vector2.left;
                break;

            // �o���ʒu�����̏ꍇ
            case RESPAWN_TYPE.DOWN:
                pos.x = Random.Range(
                    -m_respawnPosInside.x, m_respawnPosInside.x);
                pos.y = -m_respawnPosOutside.y;
                m_direction = Vector2.up;
                break;

            // �o���ʒu�����̏ꍇ
            case RESPAWN_TYPE.LEFT:
                pos.x = -m_respawnPosOutside.x;
                pos.y = Random.Range(
                    -m_respawnPosInside.y, m_respawnPosInside.y);
                m_direction = Vector2.right;
                break;
        }

        // �ʒu�𔽉f����
        transform.localPosition = pos;
    }
}