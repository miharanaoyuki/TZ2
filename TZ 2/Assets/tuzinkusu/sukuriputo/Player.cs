//使わなかったので、一応コメントアウト。
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	//敵キャラがGameManagerを介して、プレイヤーの位置情報を読み取れるようにpublicにしている。
	public Transform tf;
	public Transform tf2;
	public Transform tf3;
	public Transform tf4;


	void Awake()
	{
		tf = transform;

		tf2 = transform;

		tf3 = transform;

		tf4 = transform;


	}

	//移動やスプライトの更新部分は割愛。    



}

