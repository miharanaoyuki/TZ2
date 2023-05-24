using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp2 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 1f;
    public GameObject particleObject;
    public GameObject bossEffect;
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
            if (shop_penetration.penetration == false)
            {
                Destroy(other.gameObject);
            }



            if (enemy_HP <= 0)
            {
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ1();
                Destroy(gameObject);
                enemy_HP = 1f;
            }




        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            enemy_HP -= CircleAttack.sattack;

            


            if (enemy_HP <= 0)
            {
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ1();
                Destroy(gameObject);
                enemy_HP = 1f;
            }


        }

    }
}
