using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_attack : MonoBehaviour
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
        if(BallShooter.attack_speed > 0.4f && TZ_coin.CoinNum >2)
        {
            TZ_coin.CoinNum -= 3;
            BallShooter.attack_speed -= 0.03f;
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}