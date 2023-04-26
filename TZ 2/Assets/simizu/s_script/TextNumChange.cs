using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextNumChange : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int CoinNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "Coin:" + CoinNum;

        if (Input.GetMouseButtonDown(0))
        {
            CoinNum++;
        }
    }
}
