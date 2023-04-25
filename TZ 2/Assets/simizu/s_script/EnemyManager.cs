using UnityEngine;

// �G�̏o���𐧌䂷��R���|�[�l���g
public class EnemyManager : MonoBehaviour
{
    public Enemy[] m_enemyPrefabs; // �G�̃v���n�u���Ǘ�����z��
    public float m_interval; // �o���Ԋu�i�b�j
    float speed = 5;
    private float m_timer; // �o���^�C�~���O���Ǘ�����^�C�}�[

    // ���t���[���Ăяo�����֐�
    private void Update()
    {
        // �o���^�C�~���O���Ǘ�����^�C�}�[���X�V����
        m_timer += Time.deltaTime;

        // �܂��G���o������^�C�~���O�ł͂Ȃ��ꍇ�A
        // ���̃t���[���̏����͂����ŏI����
        if (m_timer < m_interval) return;

        // �o���^�C�~���O���Ǘ�����^�C�}�[�����Z�b�g����
        m_timer = 0;

        // �o������G�������_���Ɍ��肷��
        var enemyIndex = Random.Range(0, m_enemyPrefabs.Length);

        transform.position += new Vector3(Time.deltaTime * speed, 0, 0);

        if (transform.position.x >= 5) ;
            // �o������G�̃v���n�u��z�񂩂�擾����
            var enemyPrefab = m_enemyPrefabs[enemyIndex];

        // �G�̃Q�[���I�u�W�F�N�g�𐶐�����
        var enemy = Instantiate(enemyPrefab);

        // �G����ʊO�̂ǂ̈ʒu�ɏo�������邩�����_���Ɍ��肷��
        var respawnType = (RESPAWN_TYPE)Random.Range(
            0, (int)RESPAWN_TYPE.SIZEOF);

        // �G������������
        enemy.Init(respawnType);
    }
}