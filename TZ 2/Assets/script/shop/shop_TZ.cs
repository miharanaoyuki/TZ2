using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_TZ : MonoBehaviour
{
    int TZ = 50;
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
        if (TZ_coin.Get_coin < 11 && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            TZ_coin.Get_coin += 1;
            TZ += 30;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}