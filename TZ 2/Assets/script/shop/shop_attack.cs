using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_attack : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 7;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if (BallShooter.attack_speed <= 0.4f)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if(BallShooter.attack_speed > 0.4f && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            BallShooter.attack_speed -= 0.03f;
            TZ += 9;
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}