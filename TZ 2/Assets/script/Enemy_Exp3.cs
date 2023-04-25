using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Exp3 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    public static float enemy_HP = 1f;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"Ç∆Ç¢Ç§ñºëOÇ≈åüçı
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            soundManager.Play("Enemy");
            enemy_HP -= Bullet_Destroy.attack;
            Destroy(other.gameObject);

           

            if (enemy_HP == 0)
            {
                Destroy(gameObject);
                enemy_HP = 1f;
            }



        }


        if (other.gameObject.tag == "sbullet")
        {
            soundManager.Play("Enemy");

            enemy_HP -= 0.5f;

          



            if (enemy_HP == 0)
            {
                Destroy(gameObject);
                enemy_HP = 1f;
            }


        }

    }
}
