using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class operation_clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EndGame();
        if (Input.GetKey(KeyCode.Return))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("shop");
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
}
