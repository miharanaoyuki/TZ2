using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_TZ : MonoBehaviour
{
    public GameObject CoinObject = null;
    int TZ = 50;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if(TZ_coin.Get_coin >= 10)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if (TZ_coin.Get_coin < 10 && TZ_coin.CoinNum >= TZ)
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