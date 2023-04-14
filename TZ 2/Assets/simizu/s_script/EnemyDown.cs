using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDown : MonoBehaviour
{
    //スクロールスピード
    [SerializeField] float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        //下方向にスクロール
        transform.position -= new Vector3(0, Time.deltaTime * speed);

        if (transform.position.y <= -6f)
        {
            Destroy(gameObject);
        }
    }
}
