using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_left : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.2f, 0, 0); ;

        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
}
