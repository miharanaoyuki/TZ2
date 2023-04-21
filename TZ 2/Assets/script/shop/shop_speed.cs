using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_speed : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Shaving()
    {
        if(PlayerMove.m_speed < 0.2f)
        {
            PlayerMove.m_speed += 0.05f;
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}