using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_Sattack : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 30;
    GameObject sphere;
    GameObject sphere2;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("Sattack");
        sphere2 = GameObject.Find("Sattack2");
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI CoinText = CoinObject.GetComponent<TextMeshProUGUI>();
        CoinText.text = "TZ:" + TZ;
        if (CircleAttack.sattack >= 0.6f)
        {
            CoinText.text = "MAX";
        }
    }

    private void Shaving()
    {
        if (CircleAttack.sattack < 0.6f && TZ_coin.CoinNum >= TZ)
        {
            TZ_coin.CoinNum -= TZ;
            CircleAttack.sattack += 0.05f;
            TZ += 10;
        }

    }

    private void OnMouseOver()
    {
        sphere.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        sphere2.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);

        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }

    private void OnMouseExit()
    {
        //SphereÇÃêFÇ™å≥ÇÃêFÇ…ñﬂÇËÇ‹Ç∑ÅB
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
        sphere2.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}