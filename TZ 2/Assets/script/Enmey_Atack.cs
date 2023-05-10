using UnityEngine;

public class Enmey_Atack : MonoBehaviour
{

    public GameObject ball;
    float speed;
    [SerializeField]
    private SoundManager soundManager;

    public static bool attack_flag = true;

    public static float attack_speed = 0.6f;
    public float intervalSec = 1; //作成間隔（秒）：Inspectorで指定する
    void Start()
    {
        speed = 10.0f;  // 弾の速度
        InvokeRepeating("attack", intervalSec, intervalSec);
    }

    void Update()
    {

       

          

        

          



        
    }

    void attack()
    {
        // 弾（ゲームオブジェクト）の生成
        GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);
        Vector3 shotForward = Vector3.Scale((GameManager.Instance.player.tf.position - transform.position), new Vector3(1, 1, 0)).normalized;

        //// 向きの生成（Z成分の除去と正規化）

        clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
    }
}