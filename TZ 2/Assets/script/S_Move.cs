using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Move : MonoBehaviour
{
    public static float speed = 0.07f;
    public static bool S_Wall_flag_N = false;
    public static bool S_Wall_flag_E = false;
    public static bool S_Wall_flag_S = false;
    public static bool S_Wall_flag_W = false;

    void Start()
    {
        S_Wall_flag_N = false;
        S_Wall_flag_E = false;
        S_Wall_flag_S = false;
        S_Wall_flag_W = false;

    }

    void Update()
    {
        if (trap.trap_flag == false)
        {
            Vector2 position = transform.position;
            if (S_Wall_flag_W == false)
            {
                if (Input.GetKey("left") || Input.GetKey("a"))
                {
                    position.x -= speed;
                }
            }


            if (S_Wall_flag_E == false)
            {
                if (Input.GetKey("right") || Input.GetKey("d"))
                {
                    position.x += speed;
                }
            }


            if (S_Wall_flag_N == false)
            {
                if (Input.GetKey("up") || Input.GetKey("w"))
                {
                    position.y += speed;
                }
            }


            if (S_Wall_flag_S == false)
            {
                if (Input.GetKey("down") || Input.GetKey("s"))
                {
                    position.y -= speed;
                }
            }

            transform.position = position;
        }
    }
}
    
