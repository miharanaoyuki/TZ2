//使わなかったので、一応コメントアウト。
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	//敵キャラがGameManagerを介して、プレイヤーの位置情報を読み取れるようにpublicにしている。
	public Transform tf;

	void Awake()
	{
		tf = transform;
	}

	//移動やスプライトの更新部分は割愛。    



}

