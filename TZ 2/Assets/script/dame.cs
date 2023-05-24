using System.Collections;
using UnityEngine;

public class dame : MonoBehaviour
{
    //インスペクターから設定するか、初期化時にGetComponentして、SpriteRendererへの参照を取得しておく。

    [SerializeField]
    SpriteRenderer sr;

    //一ループの長さ(秒数)。任意の値。
    float flickerInterval = 0.075f;

    //ループ開始時の色を0～255までの整数で指定。インスペクターで指定したい場合は、[SerializeField]のコメントアウトを外せば良い。

    //元画像が白の場合は、指定した色になる。ドット絵等の場合は、白色を指定すると元画像への影響なし。アルファ値ゼロで完全に透明。

    //    [SerializeField]
    Color32 startColor = new Color32(255, 255, 255, 255);

    //ループ終了(折り返し)時の色を0～255までの整数で指定。
    //    [SerializeField]
    Color32 endColor = new Color32(255, 255, 255, 0);

    //経過時間。
    float flickerElapsedTime;

    //点滅の長さ(秒数)。任意の値。
    float flickerDuration = 2.0f;

    //点滅コルーチン管理用。
    Coroutine flicker;

    //被ダメージフラグ。
    bool isDamaged;

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    //インスペクターから設定した場合は、GetComponentする必要がなくなる為、Awakeを削除しても良い。
    void Awake()
    {
        //(スクリプトと)同じオブジェクトにSpriteRendererがある場合。
        //       sr = GetComponent<SpriteRenderer>();
        //子のオブジェクトにSpriteRendererがある場合。
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    //ダメージを受けた時に、コレを呼ぶ。
    void Damaged()
    {
        if (isDamaged)
            return;   
        StartFlicker();
    }

    void StartFlicker()
    {
        flicker = StartCoroutine("Flicker");
    }

    IEnumerator Flicker()
    {
        //レイヤーをPlayerDamageに変更
        gameObject.layer = LayerMask.NameToLayer("Player damage");
        //while文を ↓　回ループ
        int count = 20;
        while (count > 0)
        {
            //透明にする
            renderer.material.color = new Color(1, 1, 1, 0);
            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);
            //元に戻す
            renderer.material.color = new Color(1, 1, 1, 1);
            //0.05秒待つ
            yield return new WaitForSeconds(0.05f);
            count--;
        }

        //レイヤーをPlayerに戻す
        gameObject.layer = LayerMask.NameToLayer("Player");
 
    }

    //ステージ切り替え時等で、強制的にFlickerを停止させる用。
    public void ResetFlicker()
    {
        if (flicker != null)
        {
            StopCoroutine(flicker);
            flicker = null;
        }
    }

    //呼び方の一例。
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Damaged();
        }
        if (other.gameObject.tag == "boss")
        {
            Damaged();
        }

        if (other.gameObject.tag == "Enemy_At")
        {
            Damaged();
        }
        if (other.gameObject.tag == "gimmick")
        {
            Damaged();
        }
    }
}