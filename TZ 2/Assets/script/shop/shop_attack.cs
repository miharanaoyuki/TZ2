using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shop_attack : MonoBehaviour
{
    public GameObject CoinObject = null;
    public static int TZ = 7;
    GameObject sphere;
    GameObject sphere2;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("speed");
        sphere2 = GameObject.Find("speed2");
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
            BallShooter.attack_speed -= 0.05f;
            TZ += 9;
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
