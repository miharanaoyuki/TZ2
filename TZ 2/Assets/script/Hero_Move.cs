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
        //敵出現の初期化
        Enemy_Exp.enemy_flag = false;
        Enemy_Exp1.enemy_flag = false;
        Enemy_Exp2.enemy_flag = false;
        Enemy_Exp3.enemy_flag = false;
        Enemy_Exp_1.enemy_flag = false;
        Enemy_Exp1_1.enemy_flag = false;
        Enemy_Exp2_1.enemy_flag = false;
        Enemy_Exp3_1.enemy_flag = false;
        Enemy_Exp_2.enemy_flag = false;
        Enemy_Exp1_2.enemy_flag = false;
        Enemy_Exp2_2.enemy_flag = false;
        Enemy_Exp3_2.enemy_flag = false;
        //敵出現2の初期化
        Enemy_Exp5.enemy_flag = false;
        Enemy_Exp6.enemy_flag = false;
        Enemy_Exp7.enemy_flag = false;
        Enemy_Exp8.enemy_flag = false;
        Enemy_Exp5_1.enemy_flag = false;
        Enemy_Exp6_1.enemy_flag = false;
        Enemy_Exp7_1.enemy_flag = false;
        Enemy_Exp8_1.enemy_flag = false;
        Enemy_Exp5_2.enemy_flag = false;
        Enemy_Exp6_2.enemy_flag = false;
        Enemy_Exp7_2.enemy_flag = false;
        Enemy_Exp8_2.enemy_flag = false;
        //敵出現3の初期化
        Enemy_Exp9.enemy_flag = false;
        Enemy_Exp10.enemy_flag = false;
        Enemy_Exp11.enemy_flag = false;
        Enemy_Exp12.enemy_flag = false;
        Enemy_Exp9_1.enemy_flag = false;
        Enemy_Exp10_1.enemy_flag = false;
        Enemy_Exp11_1.enemy_flag = false;
        Enemy_Exp12_1.enemy_flag = false;
        Enemy_Exp9_2.enemy_flag = false;
        Enemy_Exp10_2.enemy_flag = false;
        Enemy_Exp11_2.enemy_flag = false;
        Enemy_Exp12_2.enemy_flag = false;


        Application.targetFrameRate = 60;

        //トラップ初期化
        trap.trap_flag = false;

        Wall_flag_N = false;
        Wall_flag_E = false;

        Wall_flag_S = false;
        Wall_flag_W = false;
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