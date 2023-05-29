using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp10 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 12f;
    public GameObject particleObject;
    public GameObject bossEffect;

    public static bool enemy_flag = false;


    // Start is called before the first frame update
    void Start()
    {


        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"という名前で検索
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
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            if (shop_penetration.penetration == false)
            {
                Destroy(other.gameObject);
            }



            if (enemy_HP <= 0)
            {
                enemy_flag = false;
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ3();
                Destroy(gameObject);
                enemy_HP = 2f;
            }




        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            enemy_HP -= CircleAttack.sattack;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成



            if (enemy_HP <= 0)
            {
                enemy_flag = false;
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ3();
                Destroy(gameObject);
                enemy_HP = 2f;
            }


        }

    }
}
