using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exp_bar: MonoBehaviour
{
    public static float exp_min = 0;
    public static float exp_max = 30;
    private Slider _slider;//Slider�̒l��������_slider��錾
    public GameObject EXP;//�̗̓Q�[�W�Ɏw�肷��Slider


    [SerializeField]
    private SoundManager soundManager;



    // Use this for initialization
    void Start()
    {


        _slider = EXP.GetComponent<Slider>();//slider���擾����
    }

    // Update is called once per frame
    void Update()
    {

        _slider.value = exp_min;

        _slider.maxValue = exp_max;

        //if (Experience.MAX == true)
        //{
        //    exp_min = exp_max;
        //}



        if (exp_min == exp_max)
        {
            soundManager.Play("Lv Up");
        }

    }





}
