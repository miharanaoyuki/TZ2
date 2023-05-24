using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class shop_attack_num : MonoBehaviour
{
    public GameObject CoinObject = null;
    GameObject sphere;
    GameObject sphere2;
    GameObject sphere3;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("num");
        sphere2 = GameObject.Find("num2");
        sphere3 = GameObject.Find("num3");

    }

    // Update is called once per frame
    void Update()
    {
        if (BallShooter1.attack_num1 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:100";
        }
        if (BallShooter1.attack_num1 == true && BallShooter1.attack_num2 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:200";
        }
        if (BallShooter1.attack_num2 == true && BallShooter1.attack_num3 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:300";
        }
        if (BallShooter1.attack_num3 == true && BallShooter1.attack_num4 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:400";
        }
        if (BallShooter1.attack_num4 == true)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "MAX";
        }
      
    }

    private void Shaving()
    {
        if (BallShooter1.attack_num1 == false && TZ_coin.CoinNum >= 100)
        {
            TZ_coin.CoinNum -= 100;
            BallShooter1.attack_num1 = true;
            return;
        }

        if (BallShooter1.attack_num1 == true && TZ_coin.CoinNum >= 200 && BallShooter1.attack_num2 == false)
        {
            TZ_coin.CoinNum -= 200;
            BallShooter1.attack_num2 = true;
            return;
        }

        if (BallShooter1.attack_num2 == true && TZ_coin.CoinNum >= 300 && BallShooter1.attack_num3 == false)
        {
            TZ_coin.CoinNum -= 300;
            BallShooter1.attack_num3 = true;
            return;
        }

        if (BallShooter1.attack_num3 == true && TZ_coin.CoinNum >= 400 && BallShooter1.attack_num4 == false)
        {
            TZ_coin.CoinNum -= 400;
            BallShooter1.attack_num4 = true;
            return;
        }
    }

    private void OnMouseOver()
    {
        sphere.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        sphere2.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        sphere3.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
    private void OnMouseExit()
    {
        //SphereÇÃêFÇ™å≥ÇÃêFÇ…ñﬂÇËÇ‹Ç∑ÅB
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
        sphere2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
        sphere3.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}