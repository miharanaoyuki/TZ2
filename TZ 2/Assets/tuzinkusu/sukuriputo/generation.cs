using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generation : MonoBehaviour
{
	public GameObject bullet; //���v���n�u�FInspector�Ŏw��
	public float intervalSec = 1; //�쐬�Ԋu�i�b�j�FInspector�Ŏw�肷��
								  //public AudioClip bossbulletsou;
	Transform tf; //�G��Transform
	void Awake()
	{
		tf = transform;
	}
	void Start()
	{
		//�w��b���ƂɁACreatePrefab������Ԃ����s����\��
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
	}

	void CreatePrefab()
	{
		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		

		//�v���n�u�����
		GameObject newGameObject = Instantiate(bullet) as GameObject;
		newGameObject.transform.position = GameManager.Instance.player.tf.position;

		//var audioSource = FindObjectOfType<AudioSource>();
		//audioSource.PlayOneShot(bossbulletsou);
	}
}
