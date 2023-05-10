using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2_attack : MonoBehaviour
{
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;

    private float counttime = 0.0f;//時間をはかる
    public float timeLimit = 3.0f;//制限時間

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counttime += Time.deltaTime;//マイフレーム事にかかった時間を足している

        if (counttime > timeLimit)
        {
            counttime = 0.0f;
            Instantiate(bulletPrefab1, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab3, transform.position, Quaternion.identity);
            Instantiate(bulletPrefab4, transform.position, Quaternion.identity);
        }
    }
}
