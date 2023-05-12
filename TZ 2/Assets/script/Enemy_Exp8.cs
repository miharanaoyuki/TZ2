using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp8 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 5f;
    public GameObject bossEffect;
    public GameObject particleObject;

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
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ2();
                Destroy(gameObject);
                enemy_HP = 5f;
            }


        }

        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            enemy_HP -= 0.25f;



            if (enemy_HP <= 0)
            {
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().TZ2();
                Destroy(gameObject);
                enemy_HP = 5f;
            }


        }

    }
}
