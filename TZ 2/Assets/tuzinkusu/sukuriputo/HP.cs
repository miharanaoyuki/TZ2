using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public static int life = 10;//hpを6にする。SliderのMaxValueとValueはここの値に合わせます
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider
    public static int maxHp=10;
    

    public static int MAX = 10;


    [SerializeField]
    private SoundManager soundManager;
    // Use this for initialization
    void Start()
    {
        life = maxHp;
        //Debug.Log(life);

        _slider = slider.GetComponent<Slider>();//sliderを取得する
    }

    // Update is called once per frame
    void Update()
    {
        

        _slider.maxValue = maxHp;

        //スライダーの現在値の設定


        
        _slider.value = life;

        if (life <= 0)
        {

            life = MAX;
            die();
        }
        

    }

    void die()
    {

        SceneManager.LoadScene("over");

        Debug.Log("バイバイ");

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            soundManager.Play("damage");
            life--;
        }
        //if (other.gameObject.tag == "enemy_bullet")
        //{
        //    soundManager.Play("Player_Damage");
        //    Destroy(other.gameObject);
        //    life--;
        //}
        if (other.gameObject.tag == "boss")
        {

            soundManager.Play("Player_Damage");
            life--;
        }

        if (other.gameObject.tag == "Enemy_At")
        {

            soundManager.Play("damage");
            Destroy(other.gameObject);
            life--;

        }
        if(other.gameObject.tag == "gimmick")
        {

            soundManager.Play("damage");
            life--;
        }
    }


}
