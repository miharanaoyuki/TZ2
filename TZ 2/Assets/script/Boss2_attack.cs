using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2_attack : MonoBehaviour
{
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;

    private float counttime = 0.0f;//���Ԃ��͂���
    public float timeLimit = 3.0f;//��������

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counttime += Time.deltaTime;//�}�C�t���[�����ɂ����������Ԃ𑫂��Ă���

        if (counttime > timeLimit)
        {
            counttime = 0.0f;
            Instantiate(bulletPrefab1, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab3, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab4, transform.position, Quaternion.identity);
        }
    }
}
