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
        if (Input.GetMouseButtonDown(0) == false) return;
        ChangeScene();
    }
}
