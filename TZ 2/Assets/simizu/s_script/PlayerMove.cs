using UnityEngine;

// プレイヤーを制御するコンポーネント
public class PlayerMove : MonoBehaviour
{
    public float m_speed; // 移動の速さ

    // プレイヤーのインスタンスを管理する static 変数
    public static PlayerMove m_instance;

    // ゲーム開始時に呼び出される関数
    private void Awake()
    {
        m_instance = this;
    }

    // 毎フレーム呼び出される関数
    private void Update()
    {
        // ゲームを 60 FPS 固定にする
        Application.targetFrameRate = 60;

        // 矢印キーの入力情報を取得する
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        // 矢印キーが押されている方向にプレイヤーを移動する
        var velocity = new Vector3(h, v) * m_speed;
        transform.localPosition += velocity;

        // プレイヤーが画面外に出ないように位置を制限する
        transform.localPosition = Utils.ClampPosition(transform.localPosition);
    }
}