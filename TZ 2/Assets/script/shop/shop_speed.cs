using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_speed : MonoBehaviour
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
        if(Hero_Move.speed >= 0.01f)
        {
            CoinText.text = "MAX";
        }
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