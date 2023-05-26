using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
	public static float CountDownTime;    //�J�E���g�_�E���^�C��
	public TextMeshProUGUI TextCountDown; //�\���p�e�L�X�gUI

	// Use this for initialization
	void Start()
	{
		CountDownTime = 240.5f; //�J�E���g�_�E���J�n�b�����Z�b�g
		TextCountDown.enabled = true;
	}

	// Update is called once per frame
	void Update()
	{
		//�J�E���g�_�E���^�C���𐮌`���ĕ\��
		TextCountDown.text = String.Format("BOSS  {0:0}", CountDownTime);
		//�o�ߎ����������Ă���
		CountDownTime -= Time.deltaTime;
		//if (CountDownTime <= 3.5f)
  //      {
		//	TextCountDown.enabled = true;
		//}
		if(CountDownTime <= 0.5f)
        {
			TextCountDown.enabled = false;
		}
		//0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j
		if (CountDownTime <= 0.0f)
		{
			CountDownTime = 0.0f;
		}
	}
}