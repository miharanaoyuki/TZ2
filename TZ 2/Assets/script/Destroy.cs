using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -20 || transform.position.y > 20 || transform.position.x < -20 || transform.position.x > 20 )
        {
            Destroy(gameObject);
        }
    }
}
