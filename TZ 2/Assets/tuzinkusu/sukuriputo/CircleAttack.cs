//�g��Ȃ������̂ŁA�ꉞ�R�����g�A�E�g�B
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CircleAttack: MonoBehaviour
{

	//transform�Ŗ��t���[���擾����ƕ��ׂ��|����ׁA�ʂɎQ�Ƃ�ێ��B
	Transform tf;

	//����������Rotation�B�g�p����摜�f�ނɂ���Ă͍��E�t�����B
	Quaternion leftRotation = Quaternion.Euler(0, 180, 0);
	//�E��������Rotation�B
	Quaternion rightRotation = Quaternion.Euler(0, 0, 0);

	//-1.0f�Ŏ��v���A1.0f�Ŕ����v���B
	float direction = -1.0f;

	//�ړ����x�Ƃ������ړ��p�x�B
	float moveSpeed = 3.0f;

	//�v���C���[��ǔ����鑬�x�̃��[�g(�傫��������)�B
	float followRate = 0.1f;

	//�ǔ�����|�C���g�̃v���C���[����̋���(�܂菬�������A�ߕt��)�B
	float followTargetDistance = 3.0f;
	
	float speed;
	bool flag = true;
	void Awake()
	{
		tf = transform;
	}
	void Start()
	{
		speed = 10.0f;  // �e�̑��x
	}
	//�Փ˔�������ꍇ�ɔ����A�ړ���FixedUpdate���Ŏ��s���Ă���B
	void FixedUpdate()
	{
		//�ꉞnull�`�F�b�N���Ă���B
		if (GameManager.Instance.player != null)
		{
			if (flag == true)
			{
				//�v���C���[�����̋����Œǔ��B
				tf.position = Vector3.Lerp(tf.position, GameManager.Instance.player.tf.position + (tf.position - GameManager.Instance.player.tf.position).normalized * followTargetDistance, followRate);

				//�v���C���[�𒆐S�ɉ~�^���B
				tf.RotateAround(GameManager.Instance.player.tf.position, Vector3.forward, direction * moveSpeed);

				//�G�L��������v���C���[�ւ̉������̃x�N�g�����A�}�C�i�X�Ȃ�΍������ɁA�v���X�Ȃ�ΉE�����ɐݒ�B0�Ȃ�Ζ����B
				//RotateAround�Ō������ς��̂ŁA���t���[��Rotation���㏑�����Ă���B
				//Rotation���̂�ς���ƕs�s���Ȃ�ASpriteRenderer.flipX��؂�ւ��Ă��ǂ��B  
				if (GameManager.Instance.player.tf.position.x - tf.position.x < 0)
				{
					tf.rotation = leftRotation;
				}
				else if (0 < GameManager.Instance.player.tf.position.x - tf.position.x)
				{
					tf.rotation = rightRotation;
				}


			}



			Invoke("Test2", 11f);
			


			

		}
	}

	//��]�����𔽓]�B
	void Turn()
	{
		direction = -direction;
	}

	void Test2()
	{
	 flag = false;
	 Vector3 shotForward = Vector3.Scale((GameManager.Instance.player.tf.position - transform.position), new Vector3(1, 1, 0)).normalized;
	 //// �e�ɑ��x��^����
	 //// �����̐����iZ�����̏����Ɛ��K���j

	 GetComponent<Rigidbody2D>().velocity = -shotForward* speed;
	 Debug.Log("90");
	}





	//�n�ʂւ̐N���𐧌�����ꍇ�́A�����蔻���t���āA�R���̃R�����g�A�E�g���O���B
	//�n�ʃI�u�W�F�N�g�ɁuGround�v�^�O��t���Ă����B
	/*
		void OnCollisionEnter2D(Collision2D col)
		{

			if (col.gameObject.CompareTag("Ground")) {
				Turn();
			}
		}
	*/

}