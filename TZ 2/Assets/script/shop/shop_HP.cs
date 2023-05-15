using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_HP : MonoBehaviour
{
    public GameObject CoinObject = null;
    int TZ = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if(HP.MAX >= 30)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if(HP.MAX < 30 && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            HP.MAX += 1;
            HP.maxHp += 1;
            TZ += 7;
        }
       
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}