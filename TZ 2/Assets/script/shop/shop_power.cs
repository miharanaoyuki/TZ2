using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_power : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 10;
    GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("attack");
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if(Bullet_Destroy.attack >= 5.0f)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if(Bullet_Destroy.attack < 5.0f){
            if (TZ_coin.CoinNum >= TZ)
            {
                TZ_coin.CoinNum -= TZ;
                Bullet_Destroy.attack += 0.5f;
                TZ += 10;
            }
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