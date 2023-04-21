using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destroy : MonoBehaviour
{
    public static float attack = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -20f)
        {
            Destroy(gameObject);
        }

        if (transform.position.y >= 20f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x <= -20f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x >= 20f)
        {
            Destroy(gameObject);
        }
    }
}


    
