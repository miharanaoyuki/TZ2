using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_power : MonoBehaviour
{

    int TZ = 10;
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
        if(Bullet_Destroy.attack <= 5.0f){
            if (TZ_coin.CoinNum >= TZ)
            {
                TZ_coin.CoinNum -= TZ;
                Bullet_Destroy.attack += 0.5f;
                TZ += 10;
            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}