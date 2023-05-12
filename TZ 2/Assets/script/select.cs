using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject main2;
    [SerializeField] GameObject main3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Boss_HP.clear_flag1 == true)
        {
            text2.SetActive(true);
            main2.SetActive(true);
        }

        if (Boss_HP2.clear_flag2 == true)
        {
            text3.SetActive(true);
            main3.SetActive(true);
        }
    }
}
