using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_2 : MonoBehaviour
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
        SceneManager.LoadScene("main2");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) == false) return;
        Shaving();
    }
}
