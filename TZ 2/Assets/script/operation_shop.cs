using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class operation_shop : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;

    bool Stop = true;

    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("next");
        Stop = true;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"という名前で検索
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Select");
    }
    private void EndGame()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
            Application.Quit();//ゲームプレイ終了
#endif
        }

    }

    private void OnMouseOver()
    {
        sphere.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 1);
        if (Input.GetMouseButtonDown(0))
        {
            if (Stop == true)
            {
                soundManager.Play("shop2");
                Invoke("ChangeScene", 1);
                Stop = false;
            }

        }

        return;
    }

    private void OnMouseExit()
    {
        //Sphereの色が元の色に戻ります。
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}
