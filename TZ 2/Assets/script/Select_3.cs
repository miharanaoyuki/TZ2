using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Select_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Shaving()
    {
        SceneManager.LoadScene("main3");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}

