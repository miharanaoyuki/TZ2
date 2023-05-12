using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Move: MonoBehaviour
{
    public static  float speed = 0.07f;
    public static bool Wall_flag_N = false;
    public static bool Wall_flag_E = false;

    public static bool Wall_flag_S = false;
    public static bool Wall_flag_W = false;
    void Start()
    {
        

    }

    void Update()
    {
        Vector2 position = transform.position;
        if (trap.trap_flag == false)
        {
            
            if (Wall_flag_W == false)
            {
                if (Input.GetKey("left") || Input.GetKey("a"))
                {
                    position.x -= speed;
                }
            }


            if (Wall_flag_E == false)
            {
                if (Input.GetKey("right") || Input.GetKey("d"))
                {
                    position.x += speed;
                }
            }


            if (Wall_flag_N == false)
            {
                if (Input.GetKey("up") || Input.GetKey("w"))
                {
                    position.y += speed;
                }
            }


            if (Wall_flag_S == false)
            {
                if (Input.GetKey("down") || Input.GetKey("s"))
                {
                    position.y -= speed;
                }
            }
        }
        // プレイヤーのスクリーン座標を計算する
        var screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // プレイヤーから見たマウスカーソルの方向を計算する
        var direction = Input.mousePosition - screenPos;

        // マウスカーソルが存在する方向の角度を取得する
        var angle = Utils.GetAngle(Vector3.zero, direction);

        // プレイヤーがマウスカーソルの方向を見るようにする
        //var angles = transform.localEulerAngles;
        //angles.z = angle - 90;
        //transform.localEulerAngles = angles;

        transform.position = position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall_flag_N")
        {
            S_Move.S_Wall_flag_N= true;
           
            Wall_flag_N = true;
        }
      

        if (other.gameObject.tag == "Wall_flag_E")
        {

            S_Move.S_Wall_flag_E = true;
            Wall_flag_E = true;
        }


        if (other.gameObject.tag == "Wall_flag_S")
        {
            S_Move.S_Wall_flag_S = true;

            Wall_flag_S = true;
        }


        if (other.gameObject.tag == "Wall_flag_W")
        {

            S_Move.S_Wall_flag_W = true;
            Wall_flag_W = true;
        }
    }





    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall_flag_N")
        {
            
            Wall_flag_N = false;
            S_Move.S_Wall_flag_N = false;


        }


        if (other.gameObject.tag == "Wall_flag_E")
        {
            S_Move.S_Wall_flag_E = false;
            Wall_flag_E = false;

        }


        if (other.gameObject.tag == "Wall_flag_S")
        {
            Debug.Log("みず");
            Wall_flag_S = false;
            S_Move.S_Wall_flag_S = false;


        }


        if (other.gameObject.tag == "Wall_flag_W")
        {
            S_Move.S_Wall_flag_W = false;
            Wall_flag_W = false;

        }

        

    }
}