using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject particleObject;
    new Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "bullet") //�^�O�̕t�����Q�[���I�u�W�F�N�g�ƏՓ˂���������
    //    {
    //        Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����

    //        Destroy(this.gameObject); //�Փ˂����Q�[���I�u�W�F�N�g���폜
    //    }
    //}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //�p�[�e�B�N���p�Q�[���I�u�W�F�N�g����
            //Destroy(this.gameObject); //�Փ˂����Q�[���I�u�W�F�N�g���폜
        }
    }
}