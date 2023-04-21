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
    //    if (col.gameObject.tag == "bullet") //タグの付いたゲームオブジェクトと衝突したか判別
    //    {
    //        Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成

    //        Destroy(this.gameObject); //衝突したゲームオブジェクトを削除
    //    }
    //}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            //Destroy(this.gameObject); //衝突したゲームオブジェクトを削除
        }
    }
}