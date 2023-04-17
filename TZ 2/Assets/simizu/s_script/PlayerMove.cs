using UnityEngine;

// �v���C���[�𐧌䂷��R���|�[�l���g
public class PlayerMove : MonoBehaviour
{
    public float m_speed; // �ړ��̑���

    // �v���C���[�̃C���X�^���X���Ǘ����� static �ϐ�
    public static PlayerMove m_instance;

    // �Q�[���J�n���ɌĂяo�����֐�
    private void Awake()
    {
        m_instance = this;
    }

    // ���t���[���Ăяo�����֐�
    private void Update()
    {
        // �Q�[���� 60 FPS �Œ�ɂ���
        Application.targetFrameRate = 60;

        // ���L�[�̓��͏����擾����
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        // ���L�[��������Ă�������Ƀv���C���[���ړ�����
        var velocity = new Vector3(h, v) * m_speed;
        transform.localPosition += velocity;

        // �v���C���[����ʊO�ɏo�Ȃ��悤�Ɉʒu�𐧌�����
        transform.localPosition = Utils.ClampPosition(transform.localPosition);
    }
}