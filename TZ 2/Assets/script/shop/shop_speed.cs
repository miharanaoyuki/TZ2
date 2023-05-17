using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_speed : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 5;
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("dash");
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if(Hero_Move.speed >= 0.1f)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if(Hero_Move.speed < 0.1f && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            Hero_Move.speed += 0.002f;
            TZ += 5;
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