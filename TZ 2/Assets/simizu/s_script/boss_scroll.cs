using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_scroll : MonoBehaviour
{
    //�X�N���[���X�s�[�h
    [SerializeField] float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�������ɃX�N���[��
        transform.position -= new Vector3(0, Time.deltaTime * speed);

        if (transform.position.y <= 5f)
        {
            Destroy(gameObject);
        }
    }
}
