using UnityEngine;

public class BallShooter : MonoBehaviour
{

    public GameObject ball;
    public static float speed;
    [SerializeField]
    private SoundManager soundManager;

    //public static bool attack_flag = true;

    public static float attack_speed = 1.0f;

    //一回だけ発動
    bool one = false;

    void Start()
    {
        if (one == false)
        {
            speed = 10.0f;  // 弾の速度
            one = true;
        }
        
        //attack_flag = true;
        InvokeRepeating("attack", attack_speed, attack_speed);
    }

    //void Update()
    //{

    //    if (Input.GetMouseButtonDown(0) && attack_flag == true)
    //    {

    //        // 弾（ゲームオブジェクト）の生成
    //        GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

    //        // クリックした座標の取得（スクリーン座標からワールド座標に変換）
    //        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //        // 向きの生成（Z成分の除去と正規化）
    //        Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

    //        // 弾に速度を与える
    //        clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
            

    //            soundManager.Play("atcck");

    //        attack_flag = false;
    //        Invoke("attack", attack_speed);　// 関数Test1を3秒後に実行

    //    }
    //}

    //void attack()
    //{
    //    attack_flag = true;
    //}
    void attack()
    {
        //弾（ゲームオブジェクト）の生成
               GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);

        // クリックした座標の取得（スクリーン座標からワールド座標に変換）
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 向きの生成（Z成分の除去と正規化）
        Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;

        // 弾に速度を与える
        clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;


        soundManager.Play("atcck");
    }
}