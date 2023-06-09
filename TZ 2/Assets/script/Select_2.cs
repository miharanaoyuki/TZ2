using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_2 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;

    GameObject sphere;

    bool Stop = true;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("stage2");
        Stop = true;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"という名前で検索
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ChangeScene()
    {
        if (Boss_HP.clear_flag1 == true)
        {
            SceneManager.LoadScene("main2");
        }
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
        sphere.GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
        if (Input.GetMouseButtonDown(0) )
        {
            if (Stop==true)
            {
                if (Boss_HP.clear_flag1 == false)
                {
                    soundManager.Play("key");
                }
                if (Boss_HP.clear_flag1 == true)
                {
                    soundManager.Play("シーン移動");
                }
                   
                Invoke("ChangeScene", 1);
                Stop = false;
                Invoke("STOP", 1);
               
            }

        }
        
        return;
    }

    private void STOP()
    {
        Stop = true;
    }

        private void OnMouseExit()
    {
        //Sphereの色が元の色に戻ります。
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}
