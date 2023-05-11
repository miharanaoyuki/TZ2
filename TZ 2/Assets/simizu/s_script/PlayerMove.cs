using UnityEngine;

// �v���C���[�𐧌䂷��R���|�[�l���g
public class PlayerMove : MonoBehaviour
{
    public static float m_speed = 0.1f; // �ړ��̑���

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
        //transform.localPosition = Utils.ClampPosition(transform.localPosition);

        // �v���C���[�̃X�N���[�����W���v�Z����
        var screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // �v���C���[���猩���}�E�X�J�[�\���̕������v�Z����
        var direction = Input.mousePosition - screenPos;

        // �}�E�X�J�[�\�������݂�������̊p�x���擾����
        var angle = Utils.GetAngle(Vector3.zero, direction);

        // �v���C���[���}�E�X�J�[�\���̕���������悤�ɂ���
        //var angles = transform.localEulerAngles;
        //angles.z = angle - 90;
        //transform.localEulerAngles = angles;
    }
}