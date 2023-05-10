using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp12 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 5f;
    public GameObject particleObject;
    public GameObject bossEffect;

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
            Destroy(other.gameObject);



            if (enemy_HP <= 0)
            {
                //�G�t�F�N�g�𐶐�����
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ();
                Destroy(gameObject);
                enemy_HP = 5f;
            }




        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            enemy_HP -= 0.25f;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����



            if (enemy_HP <= 0)
            {
                //�G�t�F�N�g�𐶐�����
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ();
                Destroy(gameObject);
                enemy_HP = 5f;
            }


        }

    }
}