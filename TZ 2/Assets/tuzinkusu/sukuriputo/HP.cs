using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public static int life = 10;//hp��6�ɂ���BSlider��MaxValue��Value�͂����̒l�ɍ��킹�܂�
    private Slider _slider;//Slider�̒l��������_slider��錾
    public GameObject slider;//�̗̓Q�[�W�Ɏw�肷��Slider
    public static int maxHp=10;
    

    public static int MAX = 10;


    [SerializeField]
    private SoundManager soundManager;
    // Use this for initialization
    void Start()
    {
        life = maxHp;
        //Debug.Log(life);

        _slider = slider.GetComponent<Slider>();//slider���擾����
    }

    // Update is called once per frame
    void Update()
    {
        

        _slider.maxValue = maxHp;

        //�X���C�_�[�̌��ݒl�̐ݒ�


        
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

        Debug.Log("�o�C�o�C");

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
