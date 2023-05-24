using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class shop_penetration : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 200;
    GameObject sphere;

    public static bool penetration = false;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("penetration");
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if (penetration == true)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if (penetration == false && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            penetration = true;
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
        //SphereÇÃêFÇ™å≥ÇÃêFÇ…ñﬂÇËÇ‹Ç∑ÅB
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}