//使わなかったので、一応コメントアウト。
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	//transformで毎フレーム取得すると負荷が掛かる為、別に参照を保持。
	Transform tf;

	//左向き時のRotation。使用する画像素材によっては左右逆かも。
	Quaternion leftRotation = Quaternion.Euler(0, 180, 0);
	//右向き時のRotation。
	Quaternion rightRotation = Quaternion.Euler(0, 0, 0);

	//-1.0fで時計回り、1.0fで反時計回り。
	float direction = -1.0f;

	//移動速度というか移動角度。
	float moveSpeed = 3.0f;

	//プレイヤーを追尾する速度のレート(大きい程高速)。
	float followRate = 0.1f;

	//追尾するポイントのプレイヤーからの距離(つまり小さい程、近付く)。
	float followTargetDistance = 5.0f;



	void Awake()
	{
		tf = transform;
	}

	//衝突判定を取る場合に備え、移動をFixedUpdate内で実行している。
	void FixedUpdate()
	{
		//一応nullチェックしている。
		if (GameManager.Instance.player != null)
		{

			//プレイヤーを一定の距離で追尾。
			tf.position = Vector3.Lerp(tf.position, GameManager.Instance.player.tf.position + (tf.position - GameManager.Instance.player.tf.position).normalized * followTargetDistance, followRate);

			//プレイヤーを中心に円運動。
			tf.RotateAround(GameManager.Instance.player.tf.position, Vector3.forward, direction * moveSpeed);

			//敵キャラからプレイヤーへの横向きのベクトルが、マイナスならば左向きに、プラスならば右向きに設定。0ならば無視。
			//RotateAroundで向きが変わるので、毎フレームRotationを上書きしている。
			//Rotation自体を変えると不都合なら、SpriteRenderer.flipXを切り替えても良い。  
			if (GameManager.Instance.player.tf.position.x - tf.position.x < 0)
			{
				tf.rotation = leftRotation;
			}
			else if (0 < GameManager.Instance.player.tf.position.x - tf.position.x)
			{
				tf.rotation = rightRotation;
			}

		}
	}

	//回転方向を反転。
	void Turn()
	{
		direction = -direction;
	}

	//地面への侵入を制限する場合は、当たり判定を付けて、コレのコメントアウトを外す。
	//地面オブジェクトに「Ground」タグを付けておく。
	/*
		void OnCollisionEnter2D(Collision2D col)
		{

			if (col.gameObject.CompareTag("Ground")) {
				Turn();
			}
		}
	*/

}