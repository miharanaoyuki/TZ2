using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class shop_aircraft : MonoBehaviour
{
    public GameObject CoinObject = null;
    GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("smallattack");

    }

    // Update is called once per frame
    void Update()
    {
        if (generation.S_1 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:100";
        }
        if (generation.S_1 == true && generation.S_2 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:200";
        }
        if (generation.S_2 == true && generation.S_3 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:300";
        }
        if (generation.S_3 == true && generation.S_4 == false)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "TZ:400";
        }
        if (generation.S_4 == true)
        {
            TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
            CoinText.text = "MAX";
        }
        //if (Input.GetKey("t") && Input.GetKey("u") && Input.GetKey("z") && Input.GetKey("i"))
        //{
        //    TZ_coin.CoinNum = 100000;
        //}
    }

    private void Shaving()
    {
        if (generation.S_1 == false && TZ_coin.CoinNum >= 100)
        {
            TZ_coin.CoinNum -= 100;
            generation.S_1 = true;
            return;
        }

        if (generation.S_1 == true && TZ_coin.CoinNum >= 200 && generation.S_2 == false)
        {
            TZ_coin.CoinNum -= 200;
            generation.S_2 = true;
            return;
        }

        if (generation.S_2 == true && TZ_coin.CoinNum >= 300 && generation.S_3 == false)
        {
            TZ_coin.CoinNum -= 300;
            generation.S_3 = true;
            return;
        }

        if (generation.S_3 == true && TZ_coin.CoinNum >= 400 && generation.S_4 == false)
        {
            TZ_coin.CoinNum -= 400;
            generation.S_4 = true;
            return;
        }
    }

    private void OnMouseOver()
    {
        sphere.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
    private void OnMouseExit()
    {
        //Sphere�̐F�����̐F�ɖ߂�܂��B
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}