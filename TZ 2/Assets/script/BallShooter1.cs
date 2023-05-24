using UnityEngine;

public class BallShooter1 : MonoBehaviour
{
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;

    public static bool attack_num1 = false;
    public static bool attack_num2 = false;
    public static bool attack_num3 = false;
    public static bool attack_num4 = false;

    //public static bool attack_flag = true;

    public static float attack_speed = 1.0f;

    void Start()
    {
        InvokeRepeating("attack", attack_speed, attack_speed);
    }

    void attack()
    {
        if(attack_num1 == true)
        {
            Instantiate(bulletPrefab1, transform.position, Quaternion.identity);
        }
        if (attack_num2 == true)
        {
            Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
        }
        if (attack_num3 == true)
        {
            Instantiate(bulletPrefab3, transform.position, Quaternion.identity);
        }
        if (attack_num4 == true)
        {
            Instantiate(bulletPrefab4, transform.position, Quaternion.identity);
        }
    }
}