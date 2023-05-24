using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Boss_HP2 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float boss_HP2 = 40f;
    public static float boss_MAXHP2 = 40f;
    public GameObject bossEffect;
    public GameObject particleObject;
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider
    public static bool clear_flag2 = false;

    // Start is called before the first frame update
    void Start()
    {
        boss_HP2 = boss_MAXHP2;
        _slider = GameObject.Find("boss_hp2").GetComponent<Slider>();//sliderを取得する
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"という名前で検索
    }

    // Update is called once per frame
    void Update()
    {
        _slider.maxValue = boss_MAXHP2;

        _slider.value = boss_HP2;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            soundManager.Play("Enemy");
            boss_HP2 -= Bullet_Destroy.attack;
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            if (shop_penetration.penetration == false)
            {
                Destroy(other.gameObject);
            }
            Debug.Log(boss_HP2);

            if (boss_HP2 <= 0)
            {
                clear_flag2 = true;
                //BallShooter.attack_flag = true;
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().Boss2();
                SceneManager.LoadScene("Clear");
                Destroy(gameObject);
            }




        }

        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            boss_HP2 -= CircleAttack.sattack;

            if (boss_HP2 <= 0)
            {
                clear_flag2 = true;
                //エフェクトを生成する
                GameObject effect = Instantiate(bossEffect) as GameObject;
                //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
                effect.transform.position = gameObject.transform.position;
                GameObject.Find("Coin").GetComponent<TZ_coin>().Boss2();
                SceneManager.LoadScene("Clear");
                Destroy(gameObject);
            }




        }

    }
}
