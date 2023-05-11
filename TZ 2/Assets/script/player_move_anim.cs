using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move_anim : MonoBehaviour
{
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            anim.SetBool("Up", true);
        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            anim.SetBool("LeftOrRight", true);
        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            anim.SetBool("LeftOrRight", true);
        }

        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            anim.SetBool("Down", true);
        }

        if((Input.GetKey("up") && Input.GetKey("left"))||
           (Input.GetKey("w")&& Input.GetKey("a")))
        {
            anim.SetBool("Up_LeftOrRight", true);
        }

        if ((Input.GetKey("up") && Input.GetKey("right")) ||
           (Input.GetKey("w") && Input.GetKey("d")))
        {
            anim.SetBool("Up_LeftOrRight", true);
        }

        if ((Input.GetKey("down") && Input.GetKey("left")) ||
           (Input.GetKey("s") && Input.GetKey("a")))
        {
            anim.SetBool("Down_LeftOrRight", true);
        }

        if ((Input.GetKey("down") && Input.GetKey("right")) ||
           (Input.GetKey("s") && Input.GetKey("d")))
        {
            anim.SetBool("Down_LeftOrRight", true);
        }

        else
        {
            anim.SetBool("Up", false);
            anim.SetBool("LeftOrRight", false);
            anim.SetBool("Down", false);
            anim.SetBool("Up_LeftOrRight", false);
            anim.SetBool("Down_LeftOrRight", false);
        }
    }
}
