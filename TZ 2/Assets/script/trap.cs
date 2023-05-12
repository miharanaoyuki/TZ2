using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public static bool trap_flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            trap_flag = true;
            HP.life--;
            Invoke("trap_move", 1.0f);
        }
    }

    void trap_move()
    {
        trap_flag = false;
    }
}
