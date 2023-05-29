using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_c9 : MonoBehaviour
{
    //�G�v���n�u
    public GameObject enemyPrefab;
    //�G�������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0f;
    //X���W�̍ŏ��l
    public float xMinPosition = -10f;
    //X���W�̍ő�l
    public float xMaxPosition = 10f;
    //Y���W�̍ŏ��l
    public float yMinPosition = 0f;
    //Y���W�̍ő�l
    public float yMaxPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
        interval = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        time += Time.deltaTime;
        time += Time.deltaTime;

        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
        if (time > interval && (Enemy_Exp1_2.enemy_flag == false || Enemy_Exp6_2.enemy_flag == false || Enemy_Exp10_2.enemy_flag == false))
        {
            //enemy���C���X�^���X������(��������)
            GameObject enemy = Instantiate(enemyPrefab);
            //���������G�̈ʒu�������_���ɐݒ肷��
            enemy.transform.position = GetRandomPosition();
            //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
            Enemy_Exp1_2.enemy_flag = true;
            Enemy_Exp6_2.enemy_flag = true;
            Enemy_Exp10_2.enemy_flag = true;
        }
    }

    //�����_���Ȉʒu�𐶐�����֐�
    private Vector3 GetRandomPosition()
    {
        //���ꂼ��̍��W�������_���ɐ�������
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(1.0f, 1.0f);

        //Vector3�^��Position��Ԃ�
        return new Vector3(x, y, z);
    }
}