using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
	public GameObject enemy; //作るプレハブ：Inspectorで指定
	public float intervalSec = 1; //作成間隔（秒）：Inspectorで指定する
    //public AudioClip bossbulletsou;
	Transform tf; //敵のTransform

	void Start()
	{
		//Debug.Log(attack_flag);

		//指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void Update()
	{

	}

	void CreatePrefab()
	{
		//このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = Random.Range(-8, 9);
		newPos.y = 8;
		newPos.z = 1; //手前に表示

		//プレハブを作る
		GameObject newGameObject = Instantiate(enemy) as GameObject;
		newGameObject.transform.position = newPos;

		//var audioSource = FindObjectOfType<AudioSource>();
		//audioSource.PlayOneShot(bossbulletsou);
	}
}
