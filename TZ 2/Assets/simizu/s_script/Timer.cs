using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
	public static float CountDownTime;    //カウントダウンタイム
	public TextMeshProUGUI TextCountDown; //表示用テキストUI

	// Use this for initialization
	void Start()
	{
		CountDownTime = 240.5f; //カウントダウン開始秒数をセット
		TextCountDown.enabled = true;
	}

	// Update is called once per frame
	void Update()
	{
		//カウントダウンタイムを整形して表示
		TextCountDown.text = String.Format("BOSS  {0:0}", CountDownTime);
		//経過時刻を引いていく
		CountDownTime -= Time.deltaTime;
		//if (CountDownTime <= 3.5f)
  //      {
		//	TextCountDown.enabled = true;
		//}
		if(CountDownTime <= 0.5f)
        {
			TextCountDown.enabled = false;
		}
		//0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
		if (CountDownTime <= 0.0f)
		{
			CountDownTime = 0.0f;
		}
	}
}