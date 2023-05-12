using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_speed : MonoBehaviour
{
    int TZ = 5;
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
        if(Hero_Move.speed < 0.01f && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            Hero_Move.speed += 0.002f;
            TZ += 5;
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}