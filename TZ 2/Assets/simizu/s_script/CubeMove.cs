using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 3.0f;
    private int count = 1;
    [SerializeField] Transform point2;
    [SerializeField] Transform point3;
    [SerializeField] Transform point4;
    [SerializeField] Transform point5;
    void Start()
    {
        count = 0;

    }


    void Update()
    {
        if (count == 0)
            transform.position = Vector3.MoveTowards(transform.position, point2.position, speed * Time.deltaTime);
        else if (count == 1)
            transform.position = Vector3.MoveTowards(transform.position, point3.position, speed * Time.deltaTime);
        else if (count == 2)
            transform.position = Vector3.MoveTowards(transform.position, point4.position, speed * Time.deltaTime);
        else if (count == 3)
            transform.position = Vector3.MoveTowards(transform.position, point5.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Point2")
            count = 1;
        else if (other.gameObject.name == "Point3")
            count = 2;
        else if (other.gameObject.name == "Point4")
            count = 3;
        else if (other.gameObject.name == "Point5")
            count = 0;

    }
}
