using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp11 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 15f;
    public GameObject particleObject;
    public GameObject bossEffect;

    public static bool enemy_flag = false;


    // Start is called before the first frame update
    void Start()
    {


        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"�Ƃ������O�Ō���
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            soundManager.Play("Enemy");
            enemy_HP -= Bullet_Destroy.attack;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
            if (shop_penetration.penetration == false)
            {
                Destroy(other.gameObject);
            }



            if (enemy_HP <= 0)
            {
                enemy_flag = false;
                //�G�t�F�N�g�𐶐�����
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ3();
                Destroy(gameObject);
                enemy_HP = 3f;
            }




        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            enemy_HP -= CircleAttack.sattack;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����



            if (enemy_HP <= 0)
            {
                enemy_flag = false;
                //�G�t�F�N�g�𐶐�����
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ3();
                Destroy(gameObject);
                enemy_HP = 3f;
            }


        }

    }
}