using UnityEngine;

public class Enmey_Tracking_Atack : MonoBehaviour
{

    public GameObject ball;
    float speed;
    [SerializeField]
    private SoundManager soundManager;

    public static bool attack_flag = true;
    public bool m_isFollow;
    public static float attack_speed = 0.6f;
    public float intervalSec = 1; //�쐬�Ԋu�i�b�j�FInspector�Ŏw�肷��

   
    


    void Start()
    {
        speed = 10.0f;  // �e�̑��x
        InvokeRepeating("attack", intervalSec, intervalSec);
    }

    void Update()
    {


       









    }

    void attack()
    {
        // �e�i�Q�[���I�u�W�F�N�g�j�̐���
        GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);
        //Vector3 shotForward = Vector3.Scale((GameManager.Instance.player.tf.position - transform.position), new Vector3(1, 1, 0)).normalized;

      
    }
}
