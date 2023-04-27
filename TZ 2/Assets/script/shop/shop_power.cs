using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_power : MonoBehaviour
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
        if(TZ_coin.CoinNum > 2)
        TZ_coin.CoinNum -= 3;
        Bullet_Destroy.attack += 0.5f;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}