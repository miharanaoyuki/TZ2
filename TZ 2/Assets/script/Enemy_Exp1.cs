using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp1 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 2f;
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
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Destroy(other.gameObject);

            

            if (enemy_HP <= 0)
            {
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ();
                Destroy(gameObject);
                enemy_HP = 2f;
            }




        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            enemy_HP -= 0.25f;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成



            if (enemy_HP <= 0)
            {
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ();
                Destroy(gameObject);
                enemy_HP = 2f;
            }


        }

    }
}
