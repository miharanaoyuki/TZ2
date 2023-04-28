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


    }

    void Update()
    {
        Vector2 position = transform.position;
        if (S_Wall_flag_W == false)
        {
            if (Input.GetKey("left"))
            {
                position.x -= speed;
            }
        }


        if (S_Wall_flag_E == false)
        {
            if (Input.GetKey("right"))
            {
                position.x += speed;
            }
        }


        if (S_Wall_flag_N == false)
        {
            if (Input.GetKey("up"))
            {
                position.y += speed;
            }
        }


        if (S_Wall_flag_S == false)
        {
            if (Input.GetKey("down"))
            {
                position.y -= speed;
            }
        }

        transform.position = position;
    }
}
    
