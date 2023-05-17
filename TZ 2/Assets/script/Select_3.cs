using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_3 : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;
    GameObject sphere;
    bool Stop = true;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("stage3");
        Stop = true;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"�Ƃ������O�Ō���
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ChangeScene()
    {
        if (Boss_HP2.clear_flag2 == true)
        {
            SceneManager.LoadScene("main3");
        }
    }
    private void EndGame()
    {
        //Esc�������ꂽ��
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
            Application.Quit();//�Q�[���v���C�I��
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
                soundManager.Play("�V�[���ړ�");
                Invoke("ChangeScene", 1);
                Stop = false;
            }

        }
        
        return;
    }

    private void OnMouseExit()
    {
        //Sphere�̐F�����̐F�ɖ߂�܂��B
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}


