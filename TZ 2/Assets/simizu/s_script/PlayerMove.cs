using UnityEngine;

// プレイヤーを制御するコンポーネント
public class PlayerMove : MonoBehaviour
{
    public static float m_speed = 0.1f; // 移動の速さ

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
        //transform.localPosition = Utils.ClampPosition(transform.localPosition);

        // プレイヤーのスクリーン座標を計算する
        var screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // プレイヤーから見たマウスカーソルの方向を計算する
        var direction = Input.mousePosition - screenPos;

        // マウスカーソルが存在する方向の角度を取得する
        var angle = Utils.GetAngle(Vector3.zero, direction);

        // プレイヤーがマウスカーソルの方向を見るようにする
        //var angles = transform.localEulerAngles;
        //angles.z = angle - 90;
        //transform.localEulerAngles = angles;
    }
}