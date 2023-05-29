using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_c9 : MonoBehaviour
{
    //敵プレハブ
    public GameObject enemyPrefab;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;
    //X座標の最小値
    public float xMinPosition = -10f;
    //X座標の最大値
    public float xMaxPosition = 10f;
    //Y座標の最小値
    public float yMinPosition = 0f;
    //Y座標の最大値
    public float yMaxPosition = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //時間間隔を決定する
        interval = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > interval && (Enemy_Exp1_2.enemy_flag == false || Enemy_Exp6_2.enemy_flag == false || Enemy_Exp10_2.enemy_flag == false))
        {
            //enemyをインスタンス化する(生成する)
            GameObject enemy = Instantiate(enemyPrefab);
            //生成した敵の位置をランダムに設定する
            enemy.transform.position = GetRandomPosition();
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            Enemy_Exp1_2.enemy_flag = true;
            Enemy_Exp6_2.enemy_flag = true;
            Enemy_Exp10_2.enemy_flag = true;
        }
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(1.0f, 1.0f);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}