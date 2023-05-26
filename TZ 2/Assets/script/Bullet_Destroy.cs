using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destroy : MonoBehaviour
{
    public static float attack = 1.0f;
    [SerializeField]
    private SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"という名前で検索
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }

        if (transform.position.y >= 10f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x <= -19f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x >= 19f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        

        if (other.gameObject.tag == "Enemy_At")
        {
            soundManager.Play("conflict");
            Destroy(other.gameObject);
            if (shop_penetration.penetration == false)
            {
                Destroy(gameObject);
            }


        }
       
    }


}



    
