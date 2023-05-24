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
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>(); //"SoundManager"�Ƃ������O�Ō���
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
        //Sphere�̐F�����̐F�ɖ߂�܂��B
        sphere.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}
