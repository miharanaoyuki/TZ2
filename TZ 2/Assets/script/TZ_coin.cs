using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TZ_coin : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int CoinNum = 200;
    public static int Get_coin = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + CoinNum;

        //if (Input.GetMouseButtonDown(0))
        //{
        //    CoinNum++;
        //}
    }

    public void TZ1()
    {
        CoinNum += 1;
        CoinNum += Get_coin;
    }
    public void TZ2()
    {
        CoinNum += 3;
        CoinNum += Get_coin;
    }
    public void TZ3()
    {
        CoinNum += 5;
        CoinNum += Get_coin;
    }

    public void Boss1()
    {
        CoinNum += 30;
        CoinNum += Get_coin;
    }
    public void Boss2()
    {
        CoinNum += 50;
        CoinNum += Get_coin;
    }
    public void Boss3()
    {
        CoinNum += 100;
        CoinNum += Get_coin;
    }
}
