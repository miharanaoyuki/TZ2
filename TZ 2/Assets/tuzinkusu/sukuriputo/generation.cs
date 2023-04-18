using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generation : MonoBehaviour
{
	public GameObject bullet; //作るプレハブ：Inspectorで指定
	public float intervalSec = 1; //作成間隔（秒）：Inspectorで指定する
								  //public AudioClip bossbulletsou;
	Transform tf; //敵のTransform
	void Awake()
	{
		tf = transform;
	}
	void Start()
	{
		//指定秒ごとに、CreatePrefabをくり返し実行する予約
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void CreatePrefab()
	{
		//このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		

		//プレハブを作る
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = GameManager.Instance.player.tf.position;

		//var audioSource = FindObjectOfType<AudioSource>();
		//audioSource.PlayOneShot(bossbulletsou);
	}
}
