using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss3_move : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("test1", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void test1()
    {
        Invoke("test2", 2.0f);
        transform.position = new Vector3(-12, 5, 0);
    }

    void test2()
    {
        Invoke("test3", 2.0f);
        transform.position = new Vector3(-12, -5, 0);
    }

    void test3()
    {
        Invoke("test4", 2.0f);
        transform.position = new Vector3(12, -5, 0);
    }

    void test4()
    {
        Invoke("test1", 2.0f);
        transform.position = new Vector3(12, 5, 0);
    }

}
