using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_bar_P : MonoBehaviour
{

	//transform�Ŗ��t���[���擾����ƕ��ׂ��|����ׁA�ʂɎQ�Ƃ�ێ��B
	Transform tf;


	

	//-1.0f�Ŏ��v���A1.0f�Ŕ����v���B
	float direction = -1.0f;

	//�ړ����x�Ƃ������ړ��p�x�B
	float moveSpeed = 3.0f;

	//�v���C���[��ǔ����鑬�x�̃��[�g(�傫��������)�B
	float followRate = 0.1f;

	//�ǔ�����|�C���g�̃v���C���[����̋���(�܂菬�������A�ߕt��)�B
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
