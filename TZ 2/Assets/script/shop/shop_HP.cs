using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_HP : MonoBehaviour
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
        if(HP.MAX < 30)
        {
            HP.MAX += 1;
            HP.maxHp += 1;
        }
       
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}