using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_bar_P : MonoBehaviour
{

	//transformで毎フレーム取得すると負荷が掛かる為、別に参照を保持。
	Transform tf;


	

	//-1.0fで時計回り、1.0fで反時計回り。
	float direction = -1.0f;

	//移動速度というか移動角度。
	float moveSpeed = 3.0f;

	//プレイヤーを追尾する速度のレート(大きい程高速)。
	float followRate = 0.1f;

	//追尾するポイントのプレイヤーからの距離(つまり小さい程、近付く)。
	float followTargetDistance = 1.5f;

	
	bool flag = true;
	void Awake()
	{
		tf = transform;
	}
	void Start()
	{
		Vector3 newPos = GameManager.Instance.player.tf.position;
		newPos.y -= 1.0f;
	}
	
	
}
