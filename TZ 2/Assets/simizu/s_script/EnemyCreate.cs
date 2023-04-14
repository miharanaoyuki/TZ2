using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
	public GameObject enemy; //���v���n�u�FInspector�Ŏw��
	public float intervalSec = 1; //�쐬�Ԋu�i�b�j�FInspector�Ŏw�肷��
    //public AudioClip bossbulletsou;
	Transform tf; //�G��Transform

	void Start()
	{
		//Debug.Log(attack_flag);

		//�w��b���ƂɁACreatePrefab������Ԃ����s����\��
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void Update()
	{

	}

	void CreatePrefab()
	{
		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = this.transform.position;
		newPos.x = Random.Range(-8, 9);
		newPos.y = 8;
		newPos.z = 1; //��O�ɕ\��

		//�v���n�u�����
		GameObject newGameObject = Instantiate(enemy) as GameObject;
		newGameObject.transform.position = newPos;

		//var audioSource = FindObjectOfType<AudioSource>();
		//audioSource.PlayOneShot(bossbulletsou);
	}
}
