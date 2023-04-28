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
        if (Wall_flag_W == false)
        {
            if (Input.GetKey("left"))
            {
                position.x -= speed;
            }
        }


        if (Wall_flag_E == false)
        {
            if (Input.GetKey("right"))
            {
                position.x += speed;
            }
        }


        if (Wall_flag_N == false)
        {
            if (Input.GetKey("up"))
            {
                position.y += speed;
            }
        }


        if (Wall_flag_S == false)
        {
            if (Input.GetKey("down"))
            {
                position.y -= speed;
            }
        }

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
            Debug.Log("‚Ý‚¸");
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