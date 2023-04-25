using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActive : MonoBehaviour
{
    [SerializeField] GameObject sphereObject;
    [SerializeField] GameObject cubeObject;

    void Start()
    {
        sphereObject.SetActive(false);
        cubeObject.SetActive(false);
        Invoke("SphereSet", 1.0f);
    }

    void SphereSet()
    {                         
        sphereObject.SetActive(true);
        Invoke("CubeSet", 2.0f);
    }
    void CubeSet()
    {
        cubeObject.SetActive(true);
    }
}