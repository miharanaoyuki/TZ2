using UnityEngine;

// 敵の出現を制御するコンポーネント
public class bossManager : MonoBehaviour
{
    public GameObject boss;
    public GameObject boss_HP;
    public float boss_interval;

    public static bool boss_flag = false;
    void Start()
    {

        boss_flag = false;
        if (boss_flag == false)
        {
            Invoke("Boss", boss_interval);
            boss_flag = true;
        }
    }
    // 毎フレーム呼び出される関数
   
    void Boss()
    {

        boss_HP.gameObject.SetActive(true);
        GameObject clone = Instantiate(boss, transform.position, Quaternion.identity);


        // 出現する敵のプレハブを配列から取得する



    }
}
