using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generation : MonoBehaviour
{
	public GameObject bullet;
	public GameObject bullet2;
	public GameObject bullet3;
	public GameObject bullet4;//���v���n�u�FInspector�Ŏw��
	public float intervalSec = 1; //�쐬�Ԋu�i�b�j�FInspector�Ŏw�肷��

	public static bool S_1 = false;
	public static bool S_2 = false;
	public static bool S_3 = false;
	public static bool S_4 = false;

	public static int num =0;

	public static bool com =false;
	//public AudioClip bossbulletsou;
	Transform tf;
	Transform tf2;
	Transform tf3;
	Transform tf4;
	//�G��Transform
	void Awake()
	{
		tf = transform;

		tf2 = transform;

		tf3 = transform;

		tf4 = transform;
	}
	void Start()
	{
		//�w��b���ƂɁACreatePrefab������Ԃ����s����\��
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
		num = 0;
	}


		void CreatePrefab()
	{
		//���̃I�u�W�F�N�g�͈͓̔��Ƀ����_����
		Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

		Vector3 newPos = GameManager.Instance.player.tf.position;
		newPos.x +=1.5f;


		//�v���n�u�����
		if (num == 0)
		{
			if(S_1 == true)
            {
				GameObject newGameObject = Instantiate(bullet) as GameObject;
				newGameObject.transform.position = newPos;
			}
			
		}
		if (num == 1)
		{
			if (S_2 == true)
			{
				GameObject newGameObject2 = Instantiate(bullet2) as GameObject;
				newGameObject2.transform.position = newPos;
			}
		}
		if (num == 2)
		{
			if (S_3 == true)
			{
				GameObject newGameObject3 = Instantiate(bullet3) as GameObject;
				newGameObject3.transform.position = newPos;
			}
        }
        if (num == 3)
        {
			if (S_4 == true)
			{
				GameObject newGameObject4 = Instantiate(bullet4) as GameObject;
				newGameObject4.transform.position = newPos;
			}
			
        }
		


		num++;
		if (num == 4)
		{

			
			Invoke("time", 4);
		}

	}
	void time()
	{
		num = 0;



	}
}
