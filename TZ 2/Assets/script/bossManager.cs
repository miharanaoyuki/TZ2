using UnityEngine;

// �G�̏o���𐧌䂷��R���|�[�l���g
public class bossManager : MonoBehaviour
{
    public GameObject boss;
    public GameObject boss_HP;
    public float boss_interval;

    public static bool boss_flag = false;
    void Start()
    {

        boss_flag = false;
        if (boss_flag == false)
        {
            Invoke("Boss", boss_interval);
            boss_flag = true;
        }
    }
    // ���t���[���Ăяo�����֐�
   
    void Boss()
    {

        boss_HP.gameObject.SetActive(true);
        GameObject clone = Instantiate(boss, transform.position, Quaternion.identity);


        // �o������G�̃v���n�u��z�񂩂�擾����



    }
}
